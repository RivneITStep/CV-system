var gulp = require('gulp');
var sass = require('gulp-sass');
var uglifycss = require('gulp-uglifycss');
var browserSync = require('browser-sync').create();

function saas () {
    return gulp.src('./sass/*.scss')
      .pipe(sass().on('error', sass.logError))
      .pipe(gulp.dest('./css'))
      .pipe(browserSync.stream());
  }

gulp.task('sass', saas);

function css () {
    return gulp.src('./css/*.css')
     .pipe(uglifycss({
       "uglyComments": true
     }))
     .pipe(gulp.dest('./dist/'))
     .pipe(browserSync.stream());
 }

gulp.task('css', css);

gulp.task('run', gulp.parallel('sass','css'));

function watch () {
    browserSync.init({
        server: {
            baseDir: "./"
        }
    });
    gulp.watch('./sass/*.scss', saas);
    gulp.watch('./css/*.css', css);
    gulp.watch("*.html").on('change', browserSync.reload);
}


gulp.task('watch',watch);
gulp.task('build', gulp.series(watch));

// gulp.task('default', gulp.parallel(['run', 'watch']));


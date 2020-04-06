# Address endpoints
- api/addresses/get
- api/addresses/get/persons/{cityName}
# Communication endpoints
- api/comunications/get
# Education endpoints
- api/educations/get
- api/educations/get/persons/{personId}
# Experience endpoints
- api/experiences/get
# Hobbies endpoints
- api/hobbies/get
# HrData endpoints
- api/HRDatas/get
# Languages endpoints
- api/languages/get
# LoginAdminBinder endpoints
- api/adminData/get
- api/adminData/get/{adminName}
# PersonalData endpoints
##### GET
- api/persons/get
- api/persons/get/{lastName}
- api/persons/get/{firstName}&{lastName}
- api/persons/get/full/{firstName}&{lastName}
- api/persons/get/full/{personId}
- api/persons/get/skill/{skillId}
- api/persons/get/skill/{skillName}
- api/persons/get/getCV/{loginName}
##### POST
- api/persons/post
- api/persons/post/range
# Personality endpoints
- api/personalities/get
# Personality endpoints
- api/skills/get
- api/skills/get/person/{personId}
- api/skills/get/person/{firstName}&{lastName}
# LoginCVBinder endpoints
#### GET
- api/loginCVbinder/get
#### POST
- api/loginCVbinder/post/register/{signInId}
#### PUT
- api/loginCVbinder/put/updatePersonalData/{signInId}
# SignIn endpoints
#### GET
- api/signin/get
#### POST
- api/signin/post/register/{signIn}
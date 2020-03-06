# Address endpoints
## Main endpoint
api/addresses
### Nested endpoints
- get
- get/persons/{cityName}
# Communication endpoints
## Main endpoint
api/comunications
### Nested endpoints
- get
# Education endpoints
## Main endpoint
api/educations
### Nested endpoints
- get
- get/persons/{personId}
# Experience endpoints
## Main endpoint
api/experiences
### Nested endpoints
- get
# Hobbies endpoints
## Main endpoint
api/hobbies
### Nested endpoints
- get
# HrData endpoints
## Main endpoint
api/HRDatas
### Nested endpoints
- get
# Languages endpoints
## Main endpoint
api/languages
### Nested endpoints
- get
# LoginAdminBinder endpoints
## Main endpoint
api/adminData
### Nested endpoints
- get
- get/{adminName}
# PersonalData endpoints
## Main endpoint
api/persons
### Nested endpoints
##### GET
- get
- get/{lastName}
- get/{firstName}&{lastName}
- get/full/{firstName}&{lastName}
- get/full/{personId}
- get/skill/{skillId}
- get/skill/{skillName}
- get/getCV/{loginName}
##### POST
- post
- post/range
# Personality endpoints
## Main endpoint
api/personalities
### Nested endpoints
- get
# Personality endpoints
## Main endpoint
api/skills
### Nested endpoints
- get
- get/person/{personId}
- get/person/{firstName}&{lastName}
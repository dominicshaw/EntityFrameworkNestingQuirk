# EntityFrameworkNestingQuirk

Sample project for a bug where the manager id is lost from the staff object. To replicate clone the project, create an instance of the localdb with
```cmd
dotnet ef database update --project Appraiser.Data --startup-project EntityFrameworkNestingQuirk
```
then run the Api project, then navigate to http://localhost:5000/Appraisals/1
output should be 
```
Got Staff Object   : Staff 3 has manager set to 1 - running query for appraisal
info: EntityFrameworkNestingQuirk.Controllers.AppraisalsController[0]
Appraisal Query Run: Staff 3 has manager set to 1 - run completed
```
but is
```
Got Staff Object   : Staff 3 has manager set to 1 - running query for appraisal
info: EntityFrameworkNestingQuirk.Controllers.AppraisalsController[0]
Appraisal Query Run: Staff 3 has manager set to (null) - run completed
```

### Act! Cloud (a.k.a. Act! Essentials) Faker

Command line program to generate comma delimeted sample data for import testing using the nuget package [Faker](http://www.nuget.org/packages/Faker/) and customized to our project requirements

Features:
* Saves generated files to your download's directory with a file name that indicates the number of contacts that were generated
* Allows tens, hundreds or thousands of contacts to be generated
* Program randomly creates companies or contacts with full or partial data in various formats. This 'randomness' is configurable.

Sample output:
```
FirstName,LastName,Company,JobTitle,EmailAddress,PrimaryPhoneNumber,AltPhoneNumber,Type,Line1,Line2,Line3,City,State,PostalCode,Country,AltType,AltLine1,AltLine2,AltLine3,AltCity,AltState,AltPostalCode,AltCountry,Website,Birthday,CustomField1
Hailie,,Ritchie-Shanahan,Robust fresh-thinking algorithm,hailie@ritchie-shanahan.info,(072)728-4102 x131,461-540-2120 x3653,Work,1778 Elmore Fort,,,East Kane,TN,25301-6345,Puerto Rico,Home,521 Courtney Lakes,Suite 370,Office 71,Reynoldsstad,MD,76267,Saint Martin,kuhn.uk,11/8/1974,0
florine,reichel,wintheiser-wisoky,Distributed regional benchmark,florinereichel@wintheiser-wisoky.ca,1-330-704-7357,527-756-0150 x658,Home,153 Shields Forest,Suite 083,Office 29,New Kaylah,MH,34211,Uganda,Work,56032 Ziemann Flat,,,South Chadtown,MN,68156,Svalbard & Jan Mayen Islands,leuschke.ca,4/23/1954,1
,,Price LLC,,candace@pricellc.name,(381)208-4267 x2316,(443)643-7648,Work,7681 Sawayn Tunnel,Apt. 028,,West Kirsten,UT,50015,Solomon Islands,,,,,,,,,hackett.ca,,2
,Berge,Jacobson-Littel,User-friendly modular customer loyalty,berge@jacobson-littel.name,1-771-143-1571 x2222,(067)127-3188 x850,Home,40318 Abigayle Court,,,South Millieberg,IL,38884-2858,India,Work,02422 Morissette Streets,Suite 218,,Marksberg,KY,86245-1375,Belize,mooreokuneva.ca,4/15/1965,3
margaretta,hintz,"bayer, cartwright and durgan",Visionary zero tolerance knowledge user,margaretta_hintz@bayercartwrightanddurgan.ca,1-750-027-8551 x5054,046-114-8667,Work,61087 Connelly Field,,,South Christiana,FM,37851-2868,Mayotte,Home,2234 Upton Underpass,,,South Jaycee,AR,66311-0084,Switzerland,effertz.uk,9/27/1953,4
Catharine,,Rowe-Thiel,Inverse dynamic access,catharine@rowe-thiel.us,455-226-3132 x305,(551)002-4477,Home,47443 Wolff Isle,,,North Cornelius,NM,72443-6850,Haiti,Work,670 Will Club,Suite 367,,Legrosberg,MD,11744,Morocco,heaney.name,3/13/1994,5
Dayana,,Bode Group,Open-architected full-range functionalities,dayana@bodegroup.co.uk,157.451.7214,373-317-2047 x4317,Work,30472 Annetta Spurs,,,"O'Reillyberg",MI,50706-0181,Slovakia (Slovak Republic),Home,6660 Kiley Curve,,,North Juwan,VT,15005,Saint Helena,wuckert.us,6/26/1963,6
Pedro,,"Klein, Conroy and Maggio",Polarised national software,pedro@kleinconroyandmaggio.name,151.021.5847,155.567.3850,Home,07487 Hermann Terrace,,,Serenaborough,OK,05408,French Guiana,Work,8771 Fadel Ramp,Apt. 353,,East Rosalee,MA,01406-2033,French Southern Territories,zulauf.biz,7/28/1968,7
Alena,,"Casper, Leannon and Brown",Triple-buffered scalable hierarchy,alena@casperleannonandbrown.uk,632-178-4383 x4700,(785)536-7413 x051,Work,424 Prince Trail,,,Lake Elishachester,NJ,38330-8318,Armenia,Home,732 Ashleigh Shores,,,Marciashire,NH,83536-0026,Qatar,powlowskidickens.com,8/26/1963,8
,,"Skiles, Murazik and Lakin",,ima@skilesmurazikandlakin.name,875.147.7187 x4132,1-113-027-1822,Work,20784 Harris Center,,,Barrowsview,PA,76030-2128,Hong Kong,,,,,,,,,legrosgibson.us,,9
```
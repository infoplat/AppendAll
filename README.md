# AppendAll
C#制作的拼接字符串小工具

## 开发工具

Visual Studio 2005

## 软件截图

![AppendAll截图](https://raw.githubusercontent.com/infoplat/AppendAll/master/AppendAll.jpg)

## 下载地址

Releases有编辑好的EXE文件，打包成了zip包。[点击下载](https://github.com/infoplat/AppendAll/releases/download/1.0/AppendAll.zip)

## 使用方法

比如有下面一段SQL

```sql
SELECT 
  P.ID,
  P.USERNAME,
  P.PASSWORD,
  P.FULL_NAME,
  P.LAST_NAME,
  P.CREATED_ON,
  P.UPDATED_ON 
FROM
  PERSON P,
  ACCOUNT A 
  INNER JOIN DEPARTMENT D 
    ON D.ID = P.DEPARTMENT_ID 
  INNER JOIN COMPANY C 
    ON D.COMPANY_ID = C.ID 
WHERE (P.ID = A.ID 
    AND P.FIRST_NAME LIKE ?) 
  OR (P.LAST_NAME LIKE ?) 
GROUP BY P.ID 
HAVING (P.LAST_NAME LIKE ?) 
  OR (P.FIRST_NAME LIKE ?) 
ORDER BY P.ID,
  P.FULL_NAME 
```

打算使用StringBuilder拼接到java中，可以把SQL粘贴到上图文本框中，点击"转换&复制"，转到java文件粘贴即可，如下所示

```java
sql.append(" SELECT ");
sql.append("   P.ID,");
sql.append("   P.USERNAME,");
sql.append("   P.PASSWORD,");
sql.append("   P.FULL_NAME,");
sql.append("   P.LAST_NAME,");
sql.append("   P.CREATED_ON,");
sql.append("   P.UPDATED_ON ");
sql.append(" FROM");
sql.append("   PERSON P,");
sql.append("   ACCOUNT A ");
sql.append("   INNER JOIN DEPARTMENT D ");
sql.append("     ON D.ID = P.DEPARTMENT_ID ");
sql.append("   INNER JOIN COMPANY C ");
sql.append("     ON D.COMPANY_ID = C.ID ");
sql.append(" WHERE (P.ID = A.ID ");
sql.append("     AND P.FIRST_NAME LIKE ?) ");
sql.append("   OR (P.LAST_NAME LIKE ?) ");
sql.append(" GROUP BY P.ID ");
sql.append(" HAVING (P.LAST_NAME LIKE ?) ");
sql.append("   OR (P.FIRST_NAME LIKE ?) ");
sql.append(" ORDER BY P.ID,");
sql.append("   P.FULL_NAME ");

```

# Web Images Bulk Migration with a CSV file 

## Summary

**Category:** Best use of SPE to help Content authors and Marketers.

Content authors and marketers won’t have worry about manually uploading images that already have in another web site (like Wordpress) that they are migrating to Sitecore or to import images from sites like Unplash. They only need to provide media items detail containing web addresses, and item names in form of CSV file and rest of all will be managed by this module.


## Pre-requisites

This module is dependent on Sitecore Powershell Extensions, so please make sure that you have Powershell extensions installed in your Sitecore instance.

## Installation

Provide detailed instructions on how to install the module, and include screenshots where necessary.

1. Use the Sitecore Installation wizard to install the [package](#link-to-package)
2. ???
3. Profit

## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

1.	Right click the item where the media items will be added and select Scripts > Bulk Image Package Upload.
![Menu](documentation/images/image1.png?raw=true "Menu")

2.	 You will get a Bulk Image Upload window. Provide a valid CSV file with the expected format.
![File Dialog](documentation/images/image2.png?raw=true "File Dialog")

3.	 Click Upload. 

4.	When the process finishes you will get the following message. Click Close.
![Done Msg](documentation/images/image3.png?raw=true "Done Msg")

5. You will see the media items added in the selected path. 
![Media Library](documentation/images/lastImage.png?raw=true "Media Library")

Your CSV file must have the following format.  
![File Format](documentation/images/fileFormat.png?raw=true "File Format")

## Video

[![Sitecore Hackathon Mapleton Hill Video](https://img.youtube.com/vi/Hg7SU907kiI/0.jpg)](https://www.youtube.com/watch?v=Hg7SU907kiI)

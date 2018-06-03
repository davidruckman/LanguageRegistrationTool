# Language Registration Tool
A tool for registering multiple custom cultures in Windows.

## About the Tool

This is a console application written by David Ruckman and Ken McAndrew at [RDA Corporation](http://www.rdacorp.com). If you've ever had to register dozens of custom cultures in Windows, and then repeat the process on many servers, you know what a tedious process it can be. This tool automates the Windows culture registration for you making it painless and fast.

## Configuring the Tool

The first step is to configure the tool. Open the cultures.xml file for editing.  There are 40 or so example cultures in the XML file already - delete any that you don't need. Now add the cultures you wish to register.

For each culture, add a Culture node to the file per the following example:

    <Culture>
        <Code>en-AE</Code>
        <Language>English</Language>
        <Country>U.A.E.</Country>
        <CurrencyIso>AED</CurrencyIso>
        <CurrencySymbol>د.إ.</CurrencySymbol>
        <CurrencyName>UAE Dirham</CurrencyName>
        <BaseFromCode>en-US</BaseFromCode>
        <BaseFromRegion>US</BaseFromRegion>
        <TwoLetterIsoName>en</TwoLetterIsoName>
        <ThreeLetterIsoName>eng</ThreeLetterIsoName>
        <ThreeLetterWinName>ENU</ThreeLetterWinName>
    </Culture>
    
Here are some resources for looking up the proper values to use:

http://www.nationsonline.org/oneworld/country_code_list.htm
https://www.forexrealm.com/additional-info/currencies-codes-t-z.html

When finished, save and close the XML file.

## Running the Tool

Once you've updated the XML file, compile the program and copy the reulting executable file and the XML to the server you wish to update. Double-click the .exe file to run it, and the console application will show the registration results.

The tool will skip any cultures that are already registered on the server (so you can feel free to run it multiple times, if needed).
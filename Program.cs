//*****************************************************************************
//** 1071. Greatest Common Divisor of Strings    leetcode                    **
//*****************************************************************************

int gcd(int a, int b)
{
    return b == 0 ? a : gcd(b, a % b);
}

char* gcdOfStrings(char* str1, char* str2)
{
    int len1 = strlen(str1);
    int len2 = strlen(str2);
    
    char* concat1 = (char*)malloc(len1 + len2 + 1);
    char* concat2 = (char*)malloc(len1 + len2 + 1);
    strcpy(concat1, str1);
    strcat(concat1, str2);
    strcpy(concat2, str2);
    strcat(concat2, str1);
    
    if (strcmp(concat1, concat2) != 0)
    {
        free(concat1);
        free(concat2);
        return "";}
    free(concat1);
    free(concat2);

    int commonLength = gcd(len1, len2);
    char* result = (char*)malloc(commonLength + 1);
    strncpy(result, str1, commonLength);
    result[commonLength] = '\0'; 

    return result;
}
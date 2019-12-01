"# GraphQLHandP" 

API URL - POST https://api2.vetspire.com/graphql
API Key - Authorization SFMyNTY.g3QAAAACZAAEZGF0YW0AAAAHNTA6MTgxOGQABnNpZ25lZG4GAHI8YElsAQ.1t0AfDf1vU1u4DV4rbv4j1VYa7WHaIw3kyHG2B8jm38
GraphQL Query -
query getAppointments 
{ 
    appointments 
    { 
        start 
        insertedAt 
        type 
        { 
            id 
            encounterType 
            { 
                id 
                name 
            }
            name 
        } 
        status 
        location 
        { 
            name 
        } 
        provider 
        { 
            isActive 
            name 
        } 
        patient 
        { 
            clientId
        } 
    }
}

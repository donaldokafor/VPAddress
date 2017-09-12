node {
       stage 'Check out'
    
          echo 'Checking out...'
    
          checkout scm
  
       stage 'Build dll'
        
          echo 'Building dll file...'
   
          dir ('VPA') { 
                 powershell '''dotnet restore
                        dotnet build'''
  
              }          
       stage 'test VPA'
       echo 'Tesing VPA API..'
       dir ('VPA.Test') { 
              powershell 'dotnet test VPA.Test/VPA.Test.csproj -l "trx;LogFileName=VPATest.trx"'    
       }     
}
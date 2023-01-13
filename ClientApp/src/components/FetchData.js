

import React,{useEffect, useState} from 'react'

function FetchData() {

    const [data, setData] = useState([])

    //create useffect to fetch data from api
    useEffect(() => {
        fetch("http://localhost:57495/weatherforecast")
        .then(response => response.json())
        .then(json => setData(json))
    }, [])

    console.log("data", data)
  return (
    <div>
        {
            data.map((item, index) => {
                return (
                    <div key={index}>
                        <h1>{item.title}</h1>
                        <p>{item.body}</p>
                    </div>
                )
            }
            )
            
        }
    </div>
  )
}

export default FetchData
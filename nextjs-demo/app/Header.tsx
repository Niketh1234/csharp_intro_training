import React from 'react'
import Button from './Button'

type Props = {}

const Header = (props: Props) => {
    const handler = ()=>{console.log()}
  return (
    <div className='grid grid-cols-3'>
        <div>
            <h1>My Application</h1>
        </div>

        <div>
            <Button title="Show" handler={handler()}/>
        </div>

        <div>

        </div>
    </div>
  )
}

export default Header
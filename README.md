# [Test] Sun Arround Planet
1. Implement Sun  move an object along a circular orbit around a specified target position
    a. The Sun will allows the object to rotate in the target's local coordinate system. if Sun postition change then target rotation will change.
    
    b. Radian method
        - The ComputePositionOffset(float a) method takes an angle a as input and calculates the position offset of the object on the circular orbit.

        - The angle is converted from degrees to radians.
        - Using trigonometric functions (Mathf.Cos() and Mathf.Sin()), the positionOffset is calculated based on the angle, CircleRadius, and ElevationOffset.
        - If UseTargetCoordinateSystem is enabled and a Target is assigned, the position offset is transformed into the target's local coordinate system using Target.TransformVector().
    c. In the OnDrawGizmosSelected() method, which is only executed in the Unity Editor, Gizmos are drawn to visualize the target position, radius, and other parameters of the circular orbit.
    
        - The method begins by defining variables for the target position, normal vector, forward vector, label position, and position offset.
        - If UseTargetCoordinateSystem is enabled and a Target is assigned, the normal and forward vectors are set to the target's up and forward vectors, respectively.
        - The vertical offset is calculated based on the ElevationOffset and normal vectors.
        - If the elevation offset is significant, a dotted line is drawn from the target position to the position with the vertical offset, and a label indicating the elevation offset is drawn.
        - The position is updated by adding the vertical offset, and the position offset is adjusted accordingly.
        - A wire arc is drawn around the position with the given radius.
        - A label indicating the circle radius is drawn along with a line from the target position to the position with the position offset.
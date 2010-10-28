namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OrientedBoundingBox : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OrientedBoundingBox(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _squareness5000;
		public float squareness
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _squareness5000);
			}
		}
		internal static global::MonoJavaBridge.FieldId _width5001;
		public float width
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _width5001);
			}
		}
		internal static global::MonoJavaBridge.FieldId _height5002;
		public float height
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _height5002);
			}
		}
		internal static global::MonoJavaBridge.FieldId _orientation5003;
		public float orientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _orientation5003);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerX5004;
		public float centerX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _centerX5004);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerY5005;
		public float centerY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _centerY5005);
			}
		}
		static OrientedBoundingBox()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.OrientedBoundingBox.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/OrientedBoundingBox"));
			global::android.gesture.OrientedBoundingBox._squareness5000 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "squareness", "F");
			global::android.gesture.OrientedBoundingBox._width5001 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "width", "F");
			global::android.gesture.OrientedBoundingBox._height5002 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "height", "F");
			global::android.gesture.OrientedBoundingBox._orientation5003 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "orientation", "F");
			global::android.gesture.OrientedBoundingBox._centerX5004 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "centerX", "F");
			global::android.gesture.OrientedBoundingBox._centerY5005 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "centerY", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}

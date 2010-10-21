namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OrientedBoundingBox : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OrientedBoundingBox()
		{
			InitJNI();
		}
		protected OrientedBoundingBox(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _squareness4981;
		public float squareness
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _squareness4981);
			}
		}
		internal static global::MonoJavaBridge.FieldId _width4982;
		public float width
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _width4982);
			}
		}
		internal static global::MonoJavaBridge.FieldId _height4983;
		public float height
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _height4983);
			}
		}
		internal static global::MonoJavaBridge.FieldId _orientation4984;
		public float orientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _orientation4984);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerX4985;
		public float centerX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _centerX4985);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerY4986;
		public float centerY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _centerY4986);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.OrientedBoundingBox.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/OrientedBoundingBox"));
			global::android.gesture.OrientedBoundingBox._squareness4981 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "squareness", "F");
			global::android.gesture.OrientedBoundingBox._width4982 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "width", "F");
			global::android.gesture.OrientedBoundingBox._height4983 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "height", "F");
			global::android.gesture.OrientedBoundingBox._orientation4984 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "orientation", "F");
			global::android.gesture.OrientedBoundingBox._centerX4985 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "centerX", "F");
			global::android.gesture.OrientedBoundingBox._centerY4986 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "centerY", "F");
		}
	}
}

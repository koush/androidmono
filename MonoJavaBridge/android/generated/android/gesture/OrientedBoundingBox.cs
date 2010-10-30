namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OrientedBoundingBox : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OrientedBoundingBox(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _squareness2227;
		public float squareness
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _squareness2227);
			}
		}
		internal static global::MonoJavaBridge.FieldId _width2228;
		public float width
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _width2228);
			}
		}
		internal static global::MonoJavaBridge.FieldId _height2229;
		public float height
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _height2229);
			}
		}
		internal static global::MonoJavaBridge.FieldId _orientation2230;
		public float orientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _orientation2230);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerX2231;
		public float centerX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _centerX2231);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerY2232;
		public float centerY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _centerY2232);
			}
		}
		static OrientedBoundingBox()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.OrientedBoundingBox.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/OrientedBoundingBox"));
			global::android.gesture.OrientedBoundingBox._squareness2227 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "squareness", "F");
			global::android.gesture.OrientedBoundingBox._width2228 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "width", "F");
			global::android.gesture.OrientedBoundingBox._height2229 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "height", "F");
			global::android.gesture.OrientedBoundingBox._orientation2230 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "orientation", "F");
			global::android.gesture.OrientedBoundingBox._centerX2231 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "centerX", "F");
			global::android.gesture.OrientedBoundingBox._centerY2232 = @__env.GetFieldIDNoThrow(global::android.gesture.OrientedBoundingBox.staticClass, "centerY", "F");
		}
		internal static void InitJNI()
		{
		}
	}
}

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
		internal static global::MonoJavaBridge.FieldId _squareness3063;
		public float squareness
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _width3064;
		public float width
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _height3065;
		public float height
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _orientation3066;
		public float orientation
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerX3067;
		public float centerX
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _centerY3068;
		public float centerY
		{
			get
			{
				return default(float);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.OrientedBoundingBox.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/OrientedBoundingBox"));
		}
	}
}

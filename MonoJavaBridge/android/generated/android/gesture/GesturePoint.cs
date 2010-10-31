namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GesturePoint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GesturePoint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GesturePoint.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.gesture.GesturePoint._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public GesturePoint(float arg0, float arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GesturePoint._m1.native == global::System.IntPtr.Zero)
				global::android.gesture.GesturePoint._m1 = @__env.GetMethodIDNoThrow(global::android.gesture.GesturePoint.staticClass, "<init>", "(FFJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GesturePoint.staticClass, global::android.gesture.GesturePoint._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x2217;
		public float x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _x2217);
			}
		}
		internal static global::MonoJavaBridge.FieldId _y2218;
		public float y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _y2218);
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp2219;
		public long timestamp
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _timestamp2219);
			}
		}
		static GesturePoint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GesturePoint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GesturePoint"));
			global::android.gesture.GesturePoint._x2217 = @__env.GetFieldIDNoThrow(global::android.gesture.GesturePoint.staticClass, "x", "F");
			global::android.gesture.GesturePoint._y2218 = @__env.GetFieldIDNoThrow(global::android.gesture.GesturePoint.staticClass, "y", "F");
			global::android.gesture.GesturePoint._timestamp2219 = @__env.GetFieldIDNoThrow(global::android.gesture.GesturePoint.staticClass, "timestamp", "J");
		}
	}
}

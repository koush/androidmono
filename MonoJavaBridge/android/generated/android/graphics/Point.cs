namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Point : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Point(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool equals(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Point.staticClass, "equals", "(II)Z", ref global::android.graphics.Point._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Point.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.graphics.Point._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Point.staticClass, "toString", "()Ljava/lang/String;", ref global::android.graphics.Point._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Point.staticClass, "hashCode", "()I", ref global::android.graphics.Point._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void offset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Point.staticClass, "offset", "(II)V", ref global::android.graphics.Point._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Point.staticClass, "set", "(II)V", ref global::android.graphics.Point._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void negate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Point.staticClass, "negate", "()V", ref global::android.graphics.Point._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public Point(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._m7 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Point(android.graphics.Point arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._m8 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Point() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Point._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.Point._m9 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._m9);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x2371;
		public int x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _x2371);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y2372;
		public int y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _y2372);
			}
			set
			{
			}
		}
		static Point()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Point.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Point"));
			global::android.graphics.Point._x2371 = @__env.GetFieldIDNoThrow(global::android.graphics.Point.staticClass, "x", "I");
			global::android.graphics.Point._y2372 = @__env.GetFieldIDNoThrow(global::android.graphics.Point.staticClass, "y", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}

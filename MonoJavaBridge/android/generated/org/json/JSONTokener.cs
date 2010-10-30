namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONTokener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONTokener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, "toString", "()Ljava/lang/String;", ref global::org.json.JSONTokener._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String next(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, "next", "(I)Ljava/lang/String;", ref global::org.json.JSONTokener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual char next()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, "next", "()C", ref global::org.json.JSONTokener._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual char next(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, "next", "(C)C", ref global::org.json.JSONTokener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool more()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONTokener.staticClass, "more", "()Z", ref global::org.json.JSONTokener._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object nextValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONTokener.staticClass, "nextValue", "()Ljava/lang/Object;", ref global::org.json.JSONTokener._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String nextString(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, "nextString", "(C)Ljava/lang/String;", ref global::org.json.JSONTokener._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.json.JSONException syntaxError(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONTokener.staticClass, "syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;", ref global::org.json.JSONTokener._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONException;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual char nextClean()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, "nextClean", "()C", ref global::org.json.JSONTokener._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String nextTo(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, "nextTo", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONTokener._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String nextTo(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, "nextTo", "(C)Ljava/lang/String;", ref global::org.json.JSONTokener._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void skipPast(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.json.JSONTokener.staticClass, "skipPast", "(Ljava/lang/String;)V", ref global::org.json.JSONTokener._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual char skipTo(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, "skipTo", "(C)C", ref global::org.json.JSONTokener._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void back()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.json.JSONTokener.staticClass, "back", "()V", ref global::org.json.JSONTokener._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static int dehexchar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._m14.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._m14 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "dehexchar", "(C)I");
			return @__env.CallStaticIntMethod(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public JSONTokener(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._m15.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._m15 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JSONTokener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONTokener.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONTokener"));
		}
		internal static void InitJNI()
		{
		}
	}
}

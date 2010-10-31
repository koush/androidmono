namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONStringer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONStringer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.json.JSONStringer value(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "value", "(Ljava/lang/Object;)Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.json.JSONStringer value(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "value", "(Z)Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.json.JSONStringer value(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "value", "(D)Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.json.JSONStringer value(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "value", "(J)Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONStringer.staticClass, "toString", "()Ljava/lang/String;", ref global::org.json.JSONStringer._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.json.JSONStringer array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "array", "()Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m5) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.json.JSONStringer key(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "key", "(Ljava/lang/String;)Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.json.JSONStringer @object()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "@object", "()Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m7) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::org.json.JSONStringer endArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "endArray", "()Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m8) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.json.JSONStringer endObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, "endObject", "()Lorg/json/JSONStringer;", ref global::org.json.JSONStringer._m9) as org.json.JSONStringer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public JSONStringer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONStringer._m10.native == global::System.IntPtr.Zero)
				global::org.json.JSONStringer._m10 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONStringer.staticClass, global::org.json.JSONStringer._m10);
			Init(@__env, handle);
		}
		static JSONStringer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONStringer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONStringer"));
		}
	}
}

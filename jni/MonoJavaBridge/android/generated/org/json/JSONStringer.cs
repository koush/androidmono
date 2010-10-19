namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONStringer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JSONStringer()
		{
			InitJNI();
		}
		protected JSONStringer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value27316;
		public virtual global::org.json.JSONStringer value(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value27316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value27316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value27317;
		public virtual global::org.json.JSONStringer value(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value27317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value27317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value27318;
		public virtual global::org.json.JSONStringer value(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value27318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value27318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value27319;
		public virtual global::org.json.JSONStringer value(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value27319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value27319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _toString27320;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._toString27320)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._toString27320)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _array27321;
		public virtual global::org.json.JSONStringer array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._array27321)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._array27321)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _key27322;
		public virtual global::org.json.JSONStringer key(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._key27322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._key27322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _object27323;
		public virtual global::org.json.JSONStringer @object() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._object27323)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._object27323)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _endArray27324;
		public virtual global::org.json.JSONStringer endArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._endArray27324)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._endArray27324)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _endObject27325;
		public virtual global::org.json.JSONStringer endObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._endObject27325)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._endObject27325)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _JSONStringer27326;
		public JSONStringer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONStringer.staticClass, global::org.json.JSONStringer._JSONStringer27326);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONStringer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONStringer"));
			global::org.json.JSONStringer._value27316 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(Ljava/lang/Object;)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value27317 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(Z)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value27318 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(D)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value27319 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(J)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._toString27320 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONStringer._array27321 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "array", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._key27322 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "key", "(Ljava/lang/String;)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._object27323 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "@object", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._endArray27324 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "endArray", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._endObject27325 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "endObject", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._JSONStringer27326 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "<init>", "()V");
		}
	}
}

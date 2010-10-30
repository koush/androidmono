namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONObject : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.json.JSONObject._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;D)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Z)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;I)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;J)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, "toString", "(I)Ljava/lang/String;", ref global::org.json.JSONObject._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, "toString", "()Ljava/lang/String;", ref global::org.json.JSONObject._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool getBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, "getBoolean", "(Ljava/lang/String;)Z", ref global::org.json.JSONObject._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getInt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::org.json.JSONObject._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long getLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONObject.staticClass, "getLong", "(Ljava/lang/String;)J", ref global::org.json.JSONObject._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual double getDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONObject.staticClass, "getDouble", "(Ljava/lang/String;)D", ref global::org.json.JSONObject._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, "length", "()I", ref global::org.json.JSONObject._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.Object remove(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "remove", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.json.JSONObject._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.Iterator keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::org.json.JSONObject.staticClass, "keys", "()Ljava/util/Iterator;", ref global::org.json.JSONObject._m14) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::org.json.JSONArray names()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "names", "()Lorg/json/JSONArray;", ref global::org.json.JSONObject._m15) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String quote(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m16.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m16 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONObject._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool has(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, "has", "(Ljava/lang/String;)Z", ref global::org.json.JSONObject._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isNull(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, "isNull", "(Ljava/lang/String;)Z", ref global::org.json.JSONObject._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.Object opt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "opt", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.json.JSONObject._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool optBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;Z)Z", ref global::org.json.JSONObject._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool optBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;)Z", ref global::org.json.JSONObject._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual double optDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;D)D", ref global::org.json.JSONObject._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual double optDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;)D", ref global::org.json.JSONObject._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int optInt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;)I", ref global::org.json.JSONObject._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int optInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;I)I", ref global::org.json.JSONObject._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual long optLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;)J", ref global::org.json.JSONObject._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual long optLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;J)J", ref global::org.json.JSONObject._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::java.lang.String optString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONObject._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.lang.String optString(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONObject._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::org.json.JSONArray getJSONArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", ref global::org.json.JSONObject._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::org.json.JSONArray optJSONArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "optJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", ref global::org.json.JSONObject._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::org.json.JSONObject getJSONObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::org.json.JSONObject optJSONObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "optJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::org.json.JSONObject putOpt(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "putOpt", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::org.json.JSONObject accumulate(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "accumulate", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", ref global::org.json.JSONObject._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::org.json.JSONArray toJSONArray(org.json.JSONArray arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, "toJSONArray", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;", ref global::org.json.JSONObject._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static global::java.lang.String numberToString(java.lang.Number arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m38.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m38 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "numberToString", "(Ljava/lang/Number;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public JSONObject(org.json.JSONObject arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m39.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m39 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONObject;[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public JSONObject(org.json.JSONTokener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m40.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m40 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public JSONObject(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m41.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m41 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public JSONObject() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m42.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m42 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._m42);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public JSONObject(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._m43.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._m43 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NULL7578;
		public static global::java.lang.Object NULL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.json.JSONObject.staticClass, _NULL7578)) as java.lang.Object;
			}
		}
		static JSONObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONObject"));
			global::org.json.JSONObject._NULL7578 = @__env.GetStaticFieldIDNoThrow(global::org.json.JSONObject.staticClass, "NULL", "Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}

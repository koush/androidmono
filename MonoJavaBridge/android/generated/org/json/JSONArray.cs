namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "get", "(I)Ljava/lang/Object;", ref global::org.json.JSONArray._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.json.JSONArray put(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(Ljava/lang/Object;)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.json.JSONArray put(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(IZ)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.json.JSONArray put(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(II)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.json.JSONArray put(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(IJ)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.json.JSONArray put(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(ILjava/lang/Object;)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.json.JSONArray put(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(ID)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.json.JSONArray put(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(Z)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::org.json.JSONArray put(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(D)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.json.JSONArray put(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(I)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::org.json.JSONArray put(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "put", "(J)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.json.JSONArray._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "toString", "()Ljava/lang/String;", ref global::org.json.JSONArray._m12) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "toString", "(I)Ljava/lang/String;", ref global::org.json.JSONArray._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "hashCode", "()I", ref global::org.json.JSONArray._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool getBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "getBoolean", "(I)Z", ref global::org.json.JSONArray._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "getInt", "(I)I", ref global::org.json.JSONArray._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONArray.staticClass, "getLong", "(I)J", ref global::org.json.JSONArray._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONArray.staticClass, "getDouble", "(I)D", ref global::org.json.JSONArray._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "length", "()I", ref global::org.json.JSONArray._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String join(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "join", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONArray._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "getString", "(I)Ljava/lang/String;", ref global::org.json.JSONArray._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "isNull", "(I)Z", ref global::org.json.JSONArray._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.Object opt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "opt", "(I)Ljava/lang/Object;", ref global::org.json.JSONArray._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool optBoolean(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "optBoolean", "(IZ)Z", ref global::org.json.JSONArray._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool optBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONArray.staticClass, "optBoolean", "(I)Z", ref global::org.json.JSONArray._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual double optDouble(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONArray.staticClass, "optDouble", "(ID)D", ref global::org.json.JSONArray._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual double optDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONArray.staticClass, "optDouble", "(I)D", ref global::org.json.JSONArray._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual int optInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "optInt", "(I)I", ref global::org.json.JSONArray._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int optInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONArray.staticClass, "optInt", "(II)I", ref global::org.json.JSONArray._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual long optLong(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONArray.staticClass, "optLong", "(IJ)J", ref global::org.json.JSONArray._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual long optLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONArray.staticClass, "optLong", "(I)J", ref global::org.json.JSONArray._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.lang.String optString(int arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "optString", "(ILjava/lang/String;)Ljava/lang/String;", ref global::org.json.JSONArray._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::java.lang.String optString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONArray.staticClass, "optString", "(I)Ljava/lang/String;", ref global::org.json.JSONArray._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::org.json.JSONArray getJSONArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "getJSONArray", "(I)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::org.json.JSONArray optJSONArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "optJSONArray", "(I)Lorg/json/JSONArray;", ref global::org.json.JSONArray._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::org.json.JSONObject getJSONObject(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "getJSONObject", "(I)Lorg/json/JSONObject;", ref global::org.json.JSONArray._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::org.json.JSONObject optJSONObject(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "optJSONObject", "(I)Lorg/json/JSONObject;", ref global::org.json.JSONArray._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::org.json.JSONObject toJSONObject(org.json.JSONArray arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONArray.staticClass, "toJSONObject", "(Lorg/json/JSONArray;)Lorg/json/JSONObject;", ref global::org.json.JSONArray._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public JSONArray(org.json.JSONTokener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._m39.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._m39 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public JSONArray(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._m40.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._m40 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public JSONArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._m41.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._m41 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._m41);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public JSONArray(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONArray._m42.native == global::System.IntPtr.Zero)
				global::org.json.JSONArray._m42 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JSONArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONArray"));
		}
		internal static void InitJNI()
		{
		}
	}
}

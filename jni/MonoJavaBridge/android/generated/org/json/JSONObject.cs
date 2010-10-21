namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONObject : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JSONObject()
		{
			InitJNI();
		}
		protected JSONObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get33962;
		public virtual global::java.lang.Object get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._get33962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._get33962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put33963;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put33963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put33963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put33964;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put33964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put33964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put33965;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put33965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put33965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put33966;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put33966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put33966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put33967;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put33967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put33967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toString33968;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._toString33968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toString33968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString33969;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._toString33969)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toString33969)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean33970;
		public virtual bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._getBoolean33970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getBoolean33970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt33971;
		public virtual int getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._getInt33971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getInt33971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong33972;
		public virtual long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONObject._getLong33972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getLong33972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble33973;
		public virtual double getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONObject._getDouble33973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getDouble33973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length33974;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._length33974);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._length33974);
		}
		internal static global::MonoJavaBridge.MethodId _remove33975;
		public virtual global::java.lang.Object remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._remove33975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._remove33975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keys33976;
		public virtual global::java.util.Iterator keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._keys33976)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._keys33976)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _names33977;
		public virtual global::org.json.JSONArray names() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._names33977)) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._names33977)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _quote33978;
		public static global::java.lang.String quote(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._quote33978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString33979;
		public virtual global::java.lang.String getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._getString33979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getString33979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _has33980;
		public virtual bool has(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._has33980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._has33980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNull33981;
		public virtual bool isNull(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._isNull33981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._isNull33981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _opt33982;
		public virtual global::java.lang.Object opt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._opt33982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._opt33982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean33983;
		public virtual bool optBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._optBoolean33983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optBoolean33983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean33984;
		public virtual bool optBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._optBoolean33984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optBoolean33984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble33985;
		public virtual double optDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONObject._optDouble33985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optDouble33985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble33986;
		public virtual double optDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONObject._optDouble33986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optDouble33986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt33987;
		public virtual int optInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._optInt33987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optInt33987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt33988;
		public virtual int optInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._optInt33988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optInt33988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong33989;
		public virtual long optLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONObject._optLong33989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optLong33989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optLong33990;
		public virtual long optLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONObject._optLong33990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optLong33990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optString33991;
		public virtual global::java.lang.String optString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optString33991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optString33991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _optString33992;
		public virtual global::java.lang.String optString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optString33992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optString33992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONArray33993;
		public virtual global::org.json.JSONArray getJSONArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._getJSONArray33993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getJSONArray33993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONArray33994;
		public virtual global::org.json.JSONArray optJSONArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optJSONArray33994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optJSONArray33994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONObject33995;
		public virtual global::org.json.JSONObject getJSONObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._getJSONObject33995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getJSONObject33995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONObject33996;
		public virtual global::org.json.JSONObject optJSONObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optJSONObject33996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optJSONObject33996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _putOpt33997;
		public virtual global::org.json.JSONObject putOpt(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._putOpt33997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._putOpt33997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _accumulate33998;
		public virtual global::org.json.JSONObject accumulate(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._accumulate33998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._accumulate33998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toJSONArray33999;
		public virtual global::org.json.JSONArray toJSONArray(org.json.JSONArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._toJSONArray33999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toJSONArray33999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _numberToString34000;
		public static global::java.lang.String numberToString(java.lang.Number arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._numberToString34000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34001;
		public JSONObject(org.json.JSONObject arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34002;
		public JSONObject(org.json.JSONTokener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34003;
		public JSONObject(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34004;
		public JSONObject()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34004);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34005;
		public JSONObject(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NULL34006;
		public static global::java.lang.Object NULL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.json.JSONObject.staticClass, _NULL34006)) as java.lang.Object;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONObject"));
			global::org.json.JSONObject._get33962 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.json.JSONObject._put33963 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;D)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put33964 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Z)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put33965 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;I)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put33966 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;J)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put33967 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._toString33968 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toString", "(I)Ljava/lang/String;");
			global::org.json.JSONObject._toString33969 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONObject._getBoolean33970 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._getInt33971 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::org.json.JSONObject._getLong33972 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::org.json.JSONObject._getDouble33973 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::org.json.JSONObject._length33974 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "length", "()I");
			global::org.json.JSONObject._remove33975 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "remove", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.json.JSONObject._keys33976 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "keys", "()Ljava/util/Iterator;");
			global::org.json.JSONObject._names33977 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "names", "()Lorg/json/JSONArray;");
			global::org.json.JSONObject._quote33978 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._getString33979 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._has33980 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "has", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._isNull33981 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "isNull", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._opt33982 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "opt", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.json.JSONObject._optBoolean33983 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;Z)Z");
			global::org.json.JSONObject._optBoolean33984 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._optDouble33985 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;D)D");
			global::org.json.JSONObject._optDouble33986 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;)D");
			global::org.json.JSONObject._optInt33987 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;)I");
			global::org.json.JSONObject._optInt33988 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;I)I");
			global::org.json.JSONObject._optLong33989 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;)J");
			global::org.json.JSONObject._optLong33990 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;J)J");
			global::org.json.JSONObject._optString33991 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._optString33992 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._getJSONArray33993 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			global::org.json.JSONObject._optJSONArray33994 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			global::org.json.JSONObject._getJSONObject33995 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._optJSONObject33996 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._putOpt33997 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "putOpt", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._accumulate33998 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "accumulate", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._toJSONArray33999 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toJSONArray", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;");
			global::org.json.JSONObject._numberToString34000 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "numberToString", "(Ljava/lang/Number;)Ljava/lang/String;");
			global::org.json.JSONObject._JSONObject34001 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONObject;[Ljava/lang/String;)V");
			global::org.json.JSONObject._JSONObject34002 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::org.json.JSONObject._JSONObject34003 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.json.JSONObject._JSONObject34004 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "()V");
			global::org.json.JSONObject._JSONObject34005 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::org.json.JSONObject._NULL34006 = @__env.GetStaticFieldIDNoThrow(global::org.json.JSONObject.staticClass, "NULL", "Ljava/lang/Object;");
		}
	}
}

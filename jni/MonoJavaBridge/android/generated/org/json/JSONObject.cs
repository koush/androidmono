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
		internal static global::MonoJavaBridge.MethodId _get27271;
		public virtual global::java.lang.Object get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._get27271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._get27271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27272;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put27272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put27272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put27273;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put27273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put27273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put27274;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put27274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put27274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put27275;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put27275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put27275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put27276;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._put27276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put27276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toString27277;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._toString27277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toString27277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString27278;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._toString27278)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toString27278)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean27279;
		public virtual bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._getBoolean27279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getBoolean27279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt27280;
		public virtual int getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._getInt27280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getInt27280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong27281;
		public virtual long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONObject._getLong27281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getLong27281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble27282;
		public virtual double getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONObject._getDouble27282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getDouble27282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length27283;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._length27283);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._length27283);
		}
		internal static global::MonoJavaBridge.MethodId _remove27284;
		public virtual global::java.lang.Object remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._remove27284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._remove27284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keys27285;
		public virtual global::java.util.Iterator keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._keys27285)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._keys27285)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _names27286;
		public virtual global::org.json.JSONArray names() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._names27286)) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._names27286)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _quote27287;
		public static global::java.lang.String quote(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._quote27287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString27288;
		public virtual global::java.lang.String getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._getString27288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getString27288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _has27289;
		public virtual bool has(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._has27289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._has27289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNull27290;
		public virtual bool isNull(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._isNull27290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._isNull27290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _opt27291;
		public virtual global::java.lang.Object opt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._opt27291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._opt27291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean27292;
		public virtual bool optBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._optBoolean27292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optBoolean27292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean27293;
		public virtual bool optBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONObject._optBoolean27293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optBoolean27293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble27294;
		public virtual double optDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONObject._optDouble27294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optDouble27294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble27295;
		public virtual double optDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONObject._optDouble27295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optDouble27295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt27296;
		public virtual int optInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._optInt27296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optInt27296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt27297;
		public virtual int optInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONObject._optInt27297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optInt27297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong27298;
		public virtual long optLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONObject._optLong27298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optLong27298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optLong27299;
		public virtual long optLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONObject._optLong27299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optLong27299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optString27300;
		public virtual global::java.lang.String optString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optString27300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optString27300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _optString27301;
		public virtual global::java.lang.String optString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optString27301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optString27301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONArray27302;
		public virtual global::org.json.JSONArray getJSONArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._getJSONArray27302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getJSONArray27302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONArray27303;
		public virtual global::org.json.JSONArray optJSONArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optJSONArray27303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optJSONArray27303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONObject27304;
		public virtual global::org.json.JSONObject getJSONObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._getJSONObject27304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getJSONObject27304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONObject27305;
		public virtual global::org.json.JSONObject optJSONObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._optJSONObject27305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optJSONObject27305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _putOpt27306;
		public virtual global::org.json.JSONObject putOpt(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._putOpt27306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._putOpt27306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _accumulate27307;
		public virtual global::org.json.JSONObject accumulate(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._accumulate27307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._accumulate27307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toJSONArray27308;
		public virtual global::org.json.JSONArray toJSONArray(org.json.JSONArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONObject._toJSONArray27308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toJSONArray27308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _numberToString27309;
		public static global::java.lang.String numberToString(java.lang.Number arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._numberToString27309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject27310;
		public JSONObject(org.json.JSONObject arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject27310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject27311;
		public JSONObject(org.json.JSONTokener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject27311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject27312;
		public JSONObject(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject27312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject27313;
		public JSONObject()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject27313);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject27314;
		public JSONObject(java.util.Map arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject27314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NULL27315;
		public static global::java.lang.Object NULL
		{
			get
			{
				return default(global::java.lang.Object);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONObject"));
			global::org.json.JSONObject._get27271 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.json.JSONObject._put27272 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;D)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put27273 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Z)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put27274 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;I)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put27275 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;J)Lorg/json/JSONObject;");
			global::org.json.JSONObject._put27276 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._toString27277 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toString", "(I)Ljava/lang/String;");
			global::org.json.JSONObject._toString27278 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONObject._getBoolean27279 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._getInt27280 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::org.json.JSONObject._getLong27281 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::org.json.JSONObject._getDouble27282 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::org.json.JSONObject._length27283 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "length", "()I");
			global::org.json.JSONObject._remove27284 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "remove", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.json.JSONObject._keys27285 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "keys", "()Ljava/util/Iterator;");
			global::org.json.JSONObject._names27286 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "names", "()Lorg/json/JSONArray;");
			global::org.json.JSONObject._quote27287 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._getString27288 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._has27289 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "has", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._isNull27290 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "isNull", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._opt27291 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "opt", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.json.JSONObject._optBoolean27292 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;Z)Z");
			global::org.json.JSONObject._optBoolean27293 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;)Z");
			global::org.json.JSONObject._optDouble27294 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;D)D");
			global::org.json.JSONObject._optDouble27295 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;)D");
			global::org.json.JSONObject._optInt27296 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;)I");
			global::org.json.JSONObject._optInt27297 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;I)I");
			global::org.json.JSONObject._optLong27298 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;)J");
			global::org.json.JSONObject._optLong27299 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;J)J");
			global::org.json.JSONObject._optString27300 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._optString27301 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONObject._getJSONArray27302 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			global::org.json.JSONObject._optJSONArray27303 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			global::org.json.JSONObject._getJSONObject27304 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._optJSONObject27305 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._putOpt27306 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "putOpt", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._accumulate27307 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "accumulate", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			global::org.json.JSONObject._toJSONArray27308 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toJSONArray", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;");
			global::org.json.JSONObject._numberToString27309 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "numberToString", "(Ljava/lang/Number;)Ljava/lang/String;");
			global::org.json.JSONObject._JSONObject27310 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONObject;[Ljava/lang/String;)V");
			global::org.json.JSONObject._JSONObject27311 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::org.json.JSONObject._JSONObject27312 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.json.JSONObject._JSONObject27313 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "()V");
			global::org.json.JSONObject._JSONObject27314 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}

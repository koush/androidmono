namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JSONArray()
		{
			InitJNI();
		}
		protected JSONArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27227;
		public virtual global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._get27227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._get27227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put27228;
		public virtual global::org.json.JSONArray put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27229;
		public virtual global::org.json.JSONArray put(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27230;
		public virtual global::org.json.JSONArray put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27231;
		public virtual global::org.json.JSONArray put(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27232;
		public virtual global::org.json.JSONArray put(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27233;
		public virtual global::org.json.JSONArray put(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27234;
		public virtual global::org.json.JSONArray put(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27235;
		public virtual global::org.json.JSONArray put(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27236;
		public virtual global::org.json.JSONArray put(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put27237;
		public virtual global::org.json.JSONArray put(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put27237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put27237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _equals27238;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._equals27238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._equals27238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27239;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._toString27239)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._toString27239)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString27240;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._toString27240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._toString27240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27241;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._hashCode27241);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._hashCode27241);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean27242;
		public virtual bool getBoolean(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._getBoolean27242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getBoolean27242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt27243;
		public virtual int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._getInt27243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getInt27243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong27244;
		public virtual long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONArray._getLong27244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getLong27244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble27245;
		public virtual double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONArray._getDouble27245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getDouble27245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length27246;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._length27246);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._length27246);
		}
		internal static global::MonoJavaBridge.MethodId _join27247;
		public virtual global::java.lang.String join(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._join27247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._join27247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString27248;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._getString27248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getString27248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNull27249;
		public virtual bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._isNull27249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._isNull27249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _opt27250;
		public virtual global::java.lang.Object opt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._opt27250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._opt27250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean27251;
		public virtual bool optBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._optBoolean27251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optBoolean27251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean27252;
		public virtual bool optBoolean(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._optBoolean27252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optBoolean27252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble27253;
		public virtual double optDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONArray._optDouble27253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optDouble27253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble27254;
		public virtual double optDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONArray._optDouble27254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optDouble27254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt27255;
		public virtual int optInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._optInt27255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optInt27255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt27256;
		public virtual int optInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._optInt27256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optInt27256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong27257;
		public virtual long optLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONArray._optLong27257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optLong27257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong27258;
		public virtual long optLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONArray._optLong27258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optLong27258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optString27259;
		public virtual global::java.lang.String optString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optString27259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optString27259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _optString27260;
		public virtual global::java.lang.String optString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optString27260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optString27260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONArray27261;
		public virtual global::org.json.JSONArray getJSONArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._getJSONArray27261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getJSONArray27261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONArray27262;
		public virtual global::org.json.JSONArray optJSONArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optJSONArray27262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optJSONArray27262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONObject27263;
		public virtual global::org.json.JSONObject getJSONObject(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._getJSONObject27263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getJSONObject27263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONObject27264;
		public virtual global::org.json.JSONObject optJSONObject(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optJSONObject27264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optJSONObject27264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toJSONObject27265;
		public virtual global::org.json.JSONObject toJSONObject(org.json.JSONArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._toJSONObject27265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._toJSONObject27265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray27266;
		public JSONArray(org.json.JSONTokener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray27266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray27267;
		public JSONArray(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray27267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray27268;
		public JSONArray()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray27268);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray27269;
		public JSONArray(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray27269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONArray"));
			global::org.json.JSONArray._get27227 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::org.json.JSONArray._put27228 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(Ljava/lang/Object;)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27229 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(IZ)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27230 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(II)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27231 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(IJ)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27232 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(ILjava/lang/Object;)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27233 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(ID)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27234 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(Z)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27235 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(D)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27236 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(I)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put27237 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(J)Lorg/json/JSONArray;");
			global::org.json.JSONArray._equals27238 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.json.JSONArray._toString27239 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONArray._toString27240 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "toString", "(I)Ljava/lang/String;");
			global::org.json.JSONArray._hashCode27241 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "hashCode", "()I");
			global::org.json.JSONArray._getBoolean27242 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getBoolean", "(I)Z");
			global::org.json.JSONArray._getInt27243 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getInt", "(I)I");
			global::org.json.JSONArray._getLong27244 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getLong", "(I)J");
			global::org.json.JSONArray._getDouble27245 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getDouble", "(I)D");
			global::org.json.JSONArray._length27246 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "length", "()I");
			global::org.json.JSONArray._join27247 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "join", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONArray._getString27248 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getString", "(I)Ljava/lang/String;");
			global::org.json.JSONArray._isNull27249 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "isNull", "(I)Z");
			global::org.json.JSONArray._opt27250 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "opt", "(I)Ljava/lang/Object;");
			global::org.json.JSONArray._optBoolean27251 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optBoolean", "(IZ)Z");
			global::org.json.JSONArray._optBoolean27252 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optBoolean", "(I)Z");
			global::org.json.JSONArray._optDouble27253 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optDouble", "(ID)D");
			global::org.json.JSONArray._optDouble27254 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optDouble", "(I)D");
			global::org.json.JSONArray._optInt27255 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optInt", "(I)I");
			global::org.json.JSONArray._optInt27256 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optInt", "(II)I");
			global::org.json.JSONArray._optLong27257 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optLong", "(IJ)J");
			global::org.json.JSONArray._optLong27258 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optLong", "(I)J");
			global::org.json.JSONArray._optString27259 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optString", "(ILjava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONArray._optString27260 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optString", "(I)Ljava/lang/String;");
			global::org.json.JSONArray._getJSONArray27261 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getJSONArray", "(I)Lorg/json/JSONArray;");
			global::org.json.JSONArray._optJSONArray27262 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optJSONArray", "(I)Lorg/json/JSONArray;");
			global::org.json.JSONArray._getJSONObject27263 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getJSONObject", "(I)Lorg/json/JSONObject;");
			global::org.json.JSONArray._optJSONObject27264 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optJSONObject", "(I)Lorg/json/JSONObject;");
			global::org.json.JSONArray._toJSONObject27265 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "toJSONObject", "(Lorg/json/JSONArray;)Lorg/json/JSONObject;");
			global::org.json.JSONArray._JSONArray27266 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::org.json.JSONArray._JSONArray27267 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.json.JSONArray._JSONArray27268 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "()V");
			global::org.json.JSONArray._JSONArray27269 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}

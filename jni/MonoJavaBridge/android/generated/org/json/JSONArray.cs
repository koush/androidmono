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
		internal static global::MonoJavaBridge.MethodId _get34036;
		public virtual global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._get34036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._get34036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put34037;
		public virtual global::org.json.JSONArray put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34038;
		public virtual global::org.json.JSONArray put(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34039;
		public virtual global::org.json.JSONArray put(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34040;
		public virtual global::org.json.JSONArray put(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34041;
		public virtual global::org.json.JSONArray put(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34042;
		public virtual global::org.json.JSONArray put(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34043;
		public virtual global::org.json.JSONArray put(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34044;
		public virtual global::org.json.JSONArray put(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34045;
		public virtual global::org.json.JSONArray put(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _put34046;
		public virtual global::org.json.JSONArray put(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._put34046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._put34046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _equals34047;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._equals34047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._equals34047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString34048;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._toString34048)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._toString34048)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString34049;
		public virtual global::java.lang.String toString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._toString34049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._toString34049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34050;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._hashCode34050);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._hashCode34050);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean34051;
		public virtual bool getBoolean(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._getBoolean34051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getBoolean34051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt34052;
		public virtual int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._getInt34052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getInt34052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong34053;
		public virtual long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONArray._getLong34053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getLong34053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble34054;
		public virtual double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONArray._getDouble34054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getDouble34054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length34055;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._length34055);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._length34055);
		}
		internal static global::MonoJavaBridge.MethodId _join34056;
		public virtual global::java.lang.String join(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._join34056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._join34056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString34057;
		public virtual global::java.lang.String getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._getString34057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getString34057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNull34058;
		public virtual bool isNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._isNull34058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._isNull34058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _opt34059;
		public virtual global::java.lang.Object opt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._opt34059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._opt34059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean34060;
		public virtual bool optBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._optBoolean34060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optBoolean34060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean34061;
		public virtual bool optBoolean(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONArray._optBoolean34061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optBoolean34061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble34062;
		public virtual double optDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONArray._optDouble34062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optDouble34062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble34063;
		public virtual double optDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.json.JSONArray._optDouble34063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optDouble34063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt34064;
		public virtual int optInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._optInt34064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optInt34064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt34065;
		public virtual int optInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.json.JSONArray._optInt34065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optInt34065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong34066;
		public virtual long optLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONArray._optLong34066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optLong34066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong34067;
		public virtual long optLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.json.JSONArray._optLong34067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optLong34067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optString34068;
		public virtual global::java.lang.String optString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optString34068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optString34068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _optString34069;
		public virtual global::java.lang.String optString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optString34069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optString34069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONArray34070;
		public virtual global::org.json.JSONArray getJSONArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._getJSONArray34070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getJSONArray34070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONArray34071;
		public virtual global::org.json.JSONArray optJSONArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optJSONArray34071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optJSONArray34071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONObject34072;
		public virtual global::org.json.JSONObject getJSONObject(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._getJSONObject34072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._getJSONObject34072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONObject34073;
		public virtual global::org.json.JSONObject optJSONObject(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._optJSONObject34073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._optJSONObject34073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toJSONObject34074;
		public virtual global::org.json.JSONObject toJSONObject(org.json.JSONArray arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONArray._toJSONObject34074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONArray.staticClass, global::org.json.JSONArray._toJSONObject34074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34075;
		public JSONArray(org.json.JSONTokener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34076;
		public JSONArray(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34077;
		public JSONArray() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34077);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONArray34078;
		public JSONArray(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONArray.staticClass, global::org.json.JSONArray._JSONArray34078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONArray"));
			global::org.json.JSONArray._get34036 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::org.json.JSONArray._put34037 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(Ljava/lang/Object;)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34038 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(IZ)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34039 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(II)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34040 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(IJ)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34041 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(ILjava/lang/Object;)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34042 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(ID)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34043 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(Z)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34044 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(D)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34045 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(I)Lorg/json/JSONArray;");
			global::org.json.JSONArray._put34046 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "put", "(J)Lorg/json/JSONArray;");
			global::org.json.JSONArray._equals34047 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.json.JSONArray._toString34048 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONArray._toString34049 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "toString", "(I)Ljava/lang/String;");
			global::org.json.JSONArray._hashCode34050 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "hashCode", "()I");
			global::org.json.JSONArray._getBoolean34051 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getBoolean", "(I)Z");
			global::org.json.JSONArray._getInt34052 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getInt", "(I)I");
			global::org.json.JSONArray._getLong34053 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getLong", "(I)J");
			global::org.json.JSONArray._getDouble34054 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getDouble", "(I)D");
			global::org.json.JSONArray._length34055 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "length", "()I");
			global::org.json.JSONArray._join34056 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "join", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONArray._getString34057 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getString", "(I)Ljava/lang/String;");
			global::org.json.JSONArray._isNull34058 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "isNull", "(I)Z");
			global::org.json.JSONArray._opt34059 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "opt", "(I)Ljava/lang/Object;");
			global::org.json.JSONArray._optBoolean34060 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optBoolean", "(IZ)Z");
			global::org.json.JSONArray._optBoolean34061 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optBoolean", "(I)Z");
			global::org.json.JSONArray._optDouble34062 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optDouble", "(ID)D");
			global::org.json.JSONArray._optDouble34063 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optDouble", "(I)D");
			global::org.json.JSONArray._optInt34064 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optInt", "(I)I");
			global::org.json.JSONArray._optInt34065 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optInt", "(II)I");
			global::org.json.JSONArray._optLong34066 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optLong", "(IJ)J");
			global::org.json.JSONArray._optLong34067 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optLong", "(I)J");
			global::org.json.JSONArray._optString34068 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optString", "(ILjava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONArray._optString34069 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optString", "(I)Ljava/lang/String;");
			global::org.json.JSONArray._getJSONArray34070 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getJSONArray", "(I)Lorg/json/JSONArray;");
			global::org.json.JSONArray._optJSONArray34071 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optJSONArray", "(I)Lorg/json/JSONArray;");
			global::org.json.JSONArray._getJSONObject34072 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "getJSONObject", "(I)Lorg/json/JSONObject;");
			global::org.json.JSONArray._optJSONObject34073 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "optJSONObject", "(I)Lorg/json/JSONObject;");
			global::org.json.JSONArray._toJSONObject34074 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "toJSONObject", "(Lorg/json/JSONArray;)Lorg/json/JSONObject;");
			global::org.json.JSONArray._JSONArray34075 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::org.json.JSONArray._JSONArray34076 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.json.JSONArray._JSONArray34077 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "()V");
			global::org.json.JSONArray._JSONArray34078 = @__env.GetMethodIDNoThrow(global::org.json.JSONArray.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}

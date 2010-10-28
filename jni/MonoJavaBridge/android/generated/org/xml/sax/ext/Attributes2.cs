namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.Attributes2_))]
	public partial interface Attributes2 : Attributes
	{
		bool isSpecified(int arg0);
		bool isSpecified(java.lang.String arg0, java.lang.String arg1);
		bool isSpecified(java.lang.String arg0);
		bool isDeclared(int arg0);
		bool isDeclared(java.lang.String arg0);
		bool isDeclared(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.Attributes2))]
	internal sealed partial class Attributes2_ : java.lang.Object, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Attributes2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35077;
		bool org.xml.sax.ext.Attributes2.isSpecified(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified35077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified35077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35078;
		bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified35078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified35078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35079;
		bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified35079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified35079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35080;
		bool org.xml.sax.ext.Attributes2.isDeclared(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared35080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared35080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35081;
		bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared35081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared35081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35082;
		bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared35082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared35082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLength35083;
		int org.xml.sax.Attributes.getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getLength35083);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getLength35083);
		}
		internal static global::MonoJavaBridge.MethodId _getValue35084;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue35084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue35084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35085;
		global::java.lang.String org.xml.sax.Attributes.getValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue35085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue35085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35086;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue35086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue35086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35087;
		global::java.lang.String org.xml.sax.Attributes.getType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType35087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType35087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35088;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType35088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType35088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35089;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType35089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType35089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35090;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getIndex35090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getIndex35090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35091;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getIndex35091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getIndex35091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getQName35092;
		global::java.lang.String org.xml.sax.Attributes.getQName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getQName35092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getQName35092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName35093;
		global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getLocalName35093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getLocalName35093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI35094;
		global::java.lang.String org.xml.sax.Attributes.getURI(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getURI35094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getURI35094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static Attributes2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2"));
			global::org.xml.sax.ext.Attributes2_._isSpecified35077 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(I)Z");
			global::org.xml.sax.ext.Attributes2_._isSpecified35078 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isSpecified35079 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared35080 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(I)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared35081 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared35082 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._getLength35083 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getLength", "()I");
			global::org.xml.sax.ext.Attributes2_._getValue35084 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getValue35085 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getValue35086 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType35087 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType35088 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType35089 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getIndex35090 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.ext.Attributes2_._getIndex35091 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.ext.Attributes2_._getQName35092 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getLocalName35093 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getURI35094 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getURI", "(I)Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}

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
	public sealed partial class Attributes2_ : java.lang.Object, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Attributes2_()
		{
			InitJNI();
		}
		internal Attributes2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified34958;
		 bool org.xml.sax.ext.Attributes2.isSpecified(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified34958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified34958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified34959;
		 bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified34959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified34959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified34960;
		 bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified34960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified34960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared34961;
		 bool org.xml.sax.ext.Attributes2.isDeclared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared34961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared34961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared34962;
		 bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared34962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared34962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared34963;
		 bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared34963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared34963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLength34964;
		 int org.xml.sax.Attributes.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getLength34964);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getLength34964);
		}
		internal static global::MonoJavaBridge.MethodId _getValue34965;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue34965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue34965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34966;
		 global::java.lang.String org.xml.sax.Attributes.getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue34966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue34966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34967;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue34967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue34967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34968;
		 global::java.lang.String org.xml.sax.Attributes.getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType34968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType34968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34969;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType34969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType34969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34970;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType34970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType34970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex34971;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getIndex34971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getIndex34971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex34972;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getIndex34972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getIndex34972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getQName34973;
		 global::java.lang.String org.xml.sax.Attributes.getQName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getQName34973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getQName34973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34974;
		 global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getLocalName34974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getLocalName34974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI34975;
		 global::java.lang.String org.xml.sax.Attributes.getURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getURI34975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getURI34975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2"));
			global::org.xml.sax.ext.Attributes2_._isSpecified34958 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(I)Z");
			global::org.xml.sax.ext.Attributes2_._isSpecified34959 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isSpecified34960 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared34961 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(I)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared34962 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared34963 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._getLength34964 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getLength", "()I");
			global::org.xml.sax.ext.Attributes2_._getValue34965 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getValue34966 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getValue34967 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType34968 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType34969 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType34970 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getIndex34971 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.ext.Attributes2_._getIndex34972 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.ext.Attributes2_._getQName34973 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getLocalName34974 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getURI34975 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getURI", "(I)Ljava/lang/String;");
		}
	}
}

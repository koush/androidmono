namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.Attributes2_))]
	public interface Attributes2 : Attributes
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
		internal static global::MonoJavaBridge.MethodId _isSpecified28207;
		 bool org.xml.sax.ext.Attributes2.isSpecified(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified28207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified28207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified28208;
		 bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified28208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified28208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified28209;
		 bool org.xml.sax.ext.Attributes2.isSpecified(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isSpecified28209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isSpecified28209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared28210;
		 bool org.xml.sax.ext.Attributes2.isDeclared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared28210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared28210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared28211;
		 bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared28211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared28211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared28212;
		 bool org.xml.sax.ext.Attributes2.isDeclared(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._isDeclared28212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._isDeclared28212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLength28213;
		 int org.xml.sax.Attributes.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getLength28213);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getLength28213);
		}
		internal static global::MonoJavaBridge.MethodId _getValue28214;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue28214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue28214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28215;
		 global::java.lang.String org.xml.sax.Attributes.getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue28215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue28215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28216;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getValue28216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getValue28216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28217;
		 global::java.lang.String org.xml.sax.Attributes.getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType28217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType28217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28218;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType28218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType28218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28219;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getType28219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getType28219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28220;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getIndex28220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getIndex28220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28221;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getIndex28221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getIndex28221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getQName28222;
		 global::java.lang.String org.xml.sax.Attributes.getQName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getQName28222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getQName28222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName28223;
		 global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getLocalName28223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getLocalName28223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI28224;
		 global::java.lang.String org.xml.sax.Attributes.getURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_._getURI28224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2_.staticClass, global::org.xml.sax.ext.Attributes2_._getURI28224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2"));
			global::org.xml.sax.ext.Attributes2_._isSpecified28207 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(I)Z");
			global::org.xml.sax.ext.Attributes2_._isSpecified28208 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isSpecified28209 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isSpecified", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared28210 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(I)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared28211 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._isDeclared28212 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2_._getLength28213 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getLength", "()I");
			global::org.xml.sax.ext.Attributes2_._getValue28214 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getValue28215 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getValue28216 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType28217 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType28218 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getType28219 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getIndex28220 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.ext.Attributes2_._getIndex28221 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.ext.Attributes2_._getQName28222 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getLocalName28223 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.ext.Attributes2_._getURI28224 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2_.staticClass, "getURI", "(I)Ljava/lang/String;");
		}
	}
}

namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.Attributes_))]
	public partial interface Attributes  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::java.lang.String getValue(java.lang.String arg0);
		global::java.lang.String getValue(int arg0);
		global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getType(int arg0);
		global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getType(java.lang.String arg0);
		int getIndex(java.lang.String arg0);
		int getIndex(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getQName(int arg0);
		global::java.lang.String getLocalName(int arg0);
		global::java.lang.String getURI(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.Attributes))]
	internal sealed partial class Attributes_ : java.lang.Object, Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Attributes_()
		{
			InitJNI();
		}
		internal Attributes_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength34949;
		int org.xml.sax.Attributes.getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getLength34949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getLength34949);
		}
		internal static global::MonoJavaBridge.MethodId _getValue34950;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getValue34950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getValue34950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34951;
		global::java.lang.String org.xml.sax.Attributes.getValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getValue34951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getValue34951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue34952;
		global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getValue34952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getValue34952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34953;
		global::java.lang.String org.xml.sax.Attributes.getType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getType34953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getType34953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34954;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getType34954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getType34954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType34955;
		global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getType34955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getType34955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex34956;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getIndex34956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getIndex34956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex34957;
		int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getIndex34957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getIndex34957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getQName34958;
		global::java.lang.String org.xml.sax.Attributes.getQName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getQName34958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getQName34958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName34959;
		global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getLocalName34959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getLocalName34959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI34960;
		global::java.lang.String org.xml.sax.Attributes.getURI(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getURI34960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getURI34960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Attributes_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Attributes"));
			global::org.xml.sax.Attributes_._getLength34949 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getLength", "()I");
			global::org.xml.sax.Attributes_._getValue34950 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getValue34951 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getValue34952 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getType34953 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getType34954 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getType34955 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getIndex34956 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.Attributes_._getIndex34957 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.Attributes_._getQName34958 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getLocalName34959 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getURI34960 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getURI", "(I)Ljava/lang/String;");
		}
	}
}

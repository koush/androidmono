namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProtocolVersion : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProtocolVersion()
		{
			InitJNI();
		}
		protected ProtocolVersion(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31627;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._equals31627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._equals31627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31628;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._toString31628)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._toString31628)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31629;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._hashCode31629);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._hashCode31629);
		}
		internal static global::MonoJavaBridge.MethodId _clone31630;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._clone31630)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._clone31630)) as java.lang.Object;
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol31631;
		public virtual global::java.lang.String getProtocol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._getProtocol31631)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._getProtocol31631)) as java.lang.String;
		}
		public new int Major
		{
			get
			{
				return getMajor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMajor31632;
		public virtual int getMajor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._getMajor31632);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._getMajor31632);
		}
		public new int Minor
		{
			get
			{
				return getMinor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinor31633;
		public virtual int getMinor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._getMinor31633);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._getMinor31633);
		}
		internal static global::MonoJavaBridge.MethodId _forVersion31634;
		public virtual global::org.apache.http.ProtocolVersion forVersion(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._forVersion31634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._forVersion31634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _isComparable31635;
		public virtual bool isComparable(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._isComparable31635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._isComparable31635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareToVersion31636;
		public virtual int compareToVersion(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._compareToVersion31636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._compareToVersion31636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _greaterEquals31637;
		public virtual bool greaterEquals(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._greaterEquals31637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._greaterEquals31637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lessEquals31638;
		public virtual bool lessEquals(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion._lessEquals31638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._lessEquals31638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ProtocolVersion31639;
		public ProtocolVersion(java.lang.String arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._ProtocolVersion31639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ProtocolVersion.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ProtocolVersion"));
			global::org.apache.http.ProtocolVersion._equals31627 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.ProtocolVersion._toString31628 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.ProtocolVersion._hashCode31629 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "hashCode", "()I");
			global::org.apache.http.ProtocolVersion._clone31630 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.ProtocolVersion._getProtocol31631 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::org.apache.http.ProtocolVersion._getMajor31632 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "getMajor", "()I");
			global::org.apache.http.ProtocolVersion._getMinor31633 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "getMinor", "()I");
			global::org.apache.http.ProtocolVersion._forVersion31634 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "forVersion", "(II)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.ProtocolVersion._isComparable31635 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "isComparable", "(Lorg/apache/http/ProtocolVersion;)Z");
			global::org.apache.http.ProtocolVersion._compareToVersion31636 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "compareToVersion", "(Lorg/apache/http/ProtocolVersion;)I");
			global::org.apache.http.ProtocolVersion._greaterEquals31637 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "greaterEquals", "(Lorg/apache/http/ProtocolVersion;)Z");
			global::org.apache.http.ProtocolVersion._lessEquals31638 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "lessEquals", "(Lorg/apache/http/ProtocolVersion;)Z");
			global::org.apache.http.ProtocolVersion._ProtocolVersion31639 = @__env.GetMethodIDNoThrow(global::org.apache.http.ProtocolVersion.staticClass, "<init>", "(Ljava/lang/String;II)V");
		}
	}
}

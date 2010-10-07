namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ProtocolVersion : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal static global::java.lang.Class staticClass;
		static ProtocolVersion()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.ProtocolVersion), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.ProtocolVersion(@__env);
			}
		}
		protected ProtocolVersion(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals14349;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion._equals14349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._equals14349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString14350;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.ProtocolVersion._toString14350));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._toString14350));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode14351;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.ProtocolVersion._hashCode14351);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._hashCode14351);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone14352;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.ProtocolVersion._clone14352));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._clone14352));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocol14353;
		public virtual global::java.lang.String getProtocol() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.ProtocolVersion._getProtocol14353));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._getProtocol14353));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMajor14354;
		public virtual int getMajor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.ProtocolVersion._getMajor14354);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._getMajor14354);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinor14355;
		public virtual int getMinor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.ProtocolVersion._getMinor14355);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._getMinor14355);
		}
		internal static global::net.sf.jni4net.jni.MethodId _forVersion14356;
		public virtual global::org.apache.http.ProtocolVersion forVersion(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.ProtocolVersion._forVersion14356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.ProtocolVersion>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._forVersion14356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isComparable14357;
		public virtual bool isComparable(org.apache.http.ProtocolVersion arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion._isComparable14357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._isComparable14357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareToVersion14358;
		public virtual int compareToVersion(org.apache.http.ProtocolVersion arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.ProtocolVersion._compareToVersion14358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._compareToVersion14358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _greaterEquals14359;
		public virtual bool greaterEquals(org.apache.http.ProtocolVersion arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion._greaterEquals14359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._greaterEquals14359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lessEquals14360;
		public virtual bool lessEquals(org.apache.http.ProtocolVersion arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.ProtocolVersion._lessEquals14360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._lessEquals14360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProtocolVersion14361;
		public ProtocolVersion(java.lang.String arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(org.apache.http.ProtocolVersion.staticClass, global::org.apache.http.ProtocolVersion._ProtocolVersion14361, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.ProtocolVersion.staticClass = @__class;
			global::org.apache.http.ProtocolVersion._equals14349 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.ProtocolVersion._toString14350 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.ProtocolVersion._hashCode14351 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "hashCode", "()I");
			global::org.apache.http.ProtocolVersion._clone14352 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.ProtocolVersion._getProtocol14353 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::org.apache.http.ProtocolVersion._getMajor14354 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "getMajor", "()I");
			global::org.apache.http.ProtocolVersion._getMinor14355 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "getMinor", "()I");
			global::org.apache.http.ProtocolVersion._forVersion14356 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "forVersion", "(II)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.ProtocolVersion._isComparable14357 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "isComparable", "(Lorg/apache/http/ProtocolVersion;)Z");
			global::org.apache.http.ProtocolVersion._compareToVersion14358 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "compareToVersion", "(Lorg/apache/http/ProtocolVersion;)I");
			global::org.apache.http.ProtocolVersion._greaterEquals14359 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "greaterEquals", "(Lorg/apache/http/ProtocolVersion;)Z");
			global::org.apache.http.ProtocolVersion._lessEquals14360 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "lessEquals", "(Lorg/apache/http/ProtocolVersion;)Z");
			global::org.apache.http.ProtocolVersion._ProtocolVersion14361 = @__env.GetMethodID(global::org.apache.http.ProtocolVersion.staticClass, "<init>", "(Ljava/lang/String;II)V");
		}
	}
}

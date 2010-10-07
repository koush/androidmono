namespace java.nio.charset
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Charset : java.lang.Object, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static Charset()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.charset.Charset), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Charset(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _name13065;
		public virtual global::java.lang.String name() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._name13065));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._name13065));
		}
		internal static global::net.sf.jni4net.jni.MethodId _forName13066;
		public static global::java.nio.charset.Charset forName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._forName13066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13067;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.Charset._equals13067, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._equals13067, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13068;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._toString13068));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._toString13068));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13069;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.Charset._hashCode13069);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._hashCode13069);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13070;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.Charset._compareTo13070, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo13070, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13071;
		public virtual int compareTo(java.nio.charset.Charset arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.Charset._compareTo13071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo13071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains13072;
		public abstract bool contains(java.nio.charset.Charset arg0);
		internal static global::net.sf.jni4net.jni.MethodId _decode13073;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._decode13073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._decode13073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode13074;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._encode13074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode13074, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode13075;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._encode13075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode13075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSupported13076;
		public static bool isSupported(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isSupported13076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _defaultCharset13077;
		public static global::java.nio.charset.Charset defaultCharset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._defaultCharset13077));
		}
		internal static global::net.sf.jni4net.jni.MethodId _aliases13078;
		public virtual global::java.util.Set aliases() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._aliases13078));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._aliases13078));
		}
		internal static global::net.sf.jni4net.jni.MethodId _availableCharsets13079;
		public static global::java.util.SortedMap availableCharsets() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._availableCharsets13079));
		}
		internal static global::net.sf.jni4net.jni.MethodId _displayName13080;
		public virtual global::java.lang.String displayName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._displayName13080));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName13080));
		}
		internal static global::net.sf.jni4net.jni.MethodId _displayName13081;
		public virtual global::java.lang.String displayName(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._displayName13081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName13081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered13082;
		public virtual bool isRegistered() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.Charset._isRegistered13082);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isRegistered13082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _newDecoder13083;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		internal static global::net.sf.jni4net.jni.MethodId _newEncoder13084;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		internal static global::net.sf.jni4net.jni.MethodId _canEncode13085;
		public virtual bool canEncode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.Charset._canEncode13085);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._canEncode13085);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Charset13086;
		protected Charset(java.lang.String arg0, java.lang.String[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._Charset13086, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.Charset.staticClass = @__class;
			global::java.nio.charset.Charset._name13065 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._forName13066 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._equals13067 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.charset.Charset._toString13068 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._hashCode13069 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "hashCode", "()I");
			global::java.nio.charset.Charset._compareTo13070 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.charset.Charset._compareTo13071 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I");
			global::java.nio.charset.Charset._contains13072 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			global::java.nio.charset.Charset._decode13073 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.Charset._encode13074 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._encode13075 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._isSupported13076 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z");
			global::java.nio.charset.Charset._defaultCharset13077 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._aliases13078 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;");
			global::java.nio.charset.Charset._availableCharsets13079 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;");
			global::java.nio.charset.Charset._displayName13080 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._displayName13081 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.nio.charset.Charset._isRegistered13082 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z");
			global::java.nio.charset.Charset._newDecoder13083 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.Charset._newEncoder13084 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.Charset._canEncode13085 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "canEncode", "()Z");
			global::java.nio.charset.Charset._Charset13086 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V");
		}
	}
}

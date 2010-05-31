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
		internal static global::net.sf.jni4net.jni.MethodId _name12336;
		public virtual global::java.lang.String name() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._name12336));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._name12336));
		}
		internal static global::net.sf.jni4net.jni.MethodId _forName12337;
		public static global::java.nio.charset.Charset forName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._forName12337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12338;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.Charset._hashCode12338);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._hashCode12338);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12339;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.Charset._equals12339, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._equals12339, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12340;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.Charset._compareTo12340, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo12340, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12341;
		public virtual int compareTo(java.nio.charset.Charset arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.Charset._compareTo12341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo12341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12342;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._toString12342));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._toString12342));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains12343;
		public abstract bool contains(java.nio.charset.Charset arg0);
		internal static global::net.sf.jni4net.jni.MethodId _decode12344;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._decode12344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._decode12344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode12345;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._encode12345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode12345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode12346;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._encode12346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode12346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _defaultCharset12347;
		public static global::java.nio.charset.Charset defaultCharset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._defaultCharset12347));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSupported12348;
		public static bool isSupported(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isSupported12348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newEncoder12349;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		internal static global::net.sf.jni4net.jni.MethodId _aliases12350;
		public virtual global::java.util.Set aliases() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._aliases12350));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._aliases12350));
		}
		internal static global::net.sf.jni4net.jni.MethodId _availableCharsets12351;
		public static global::java.util.SortedMap availableCharsets() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._availableCharsets12351));
		}
		internal static global::net.sf.jni4net.jni.MethodId _displayName12352;
		public virtual global::java.lang.String displayName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._displayName12352));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName12352));
		}
		internal static global::net.sf.jni4net.jni.MethodId _displayName12353;
		public virtual global::java.lang.String displayName(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.Charset._displayName12353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName12353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered12354;
		public virtual bool isRegistered() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.Charset._isRegistered12354);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isRegistered12354);
		}
		internal static global::net.sf.jni4net.jni.MethodId _newDecoder12355;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		internal static global::net.sf.jni4net.jni.MethodId _canEncode12356;
		public virtual bool canEncode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.Charset._canEncode12356);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._canEncode12356);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Charset12357;
		protected Charset(java.lang.String arg0, java.lang.String[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._Charset12357, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.Charset.staticClass = @__class;
			global::java.nio.charset.Charset._name12336 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._forName12337 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._hashCode12338 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "hashCode", "()I");
			global::java.nio.charset.Charset._equals12339 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.charset.Charset._compareTo12340 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.charset.Charset._compareTo12341 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I");
			global::java.nio.charset.Charset._toString12342 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._contains12343 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			global::java.nio.charset.Charset._decode12344 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.Charset._encode12345 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._encode12346 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._defaultCharset12347 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._isSupported12348 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z");
			global::java.nio.charset.Charset._newEncoder12349 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.Charset._aliases12350 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;");
			global::java.nio.charset.Charset._availableCharsets12351 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;");
			global::java.nio.charset.Charset._displayName12352 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._displayName12353 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.nio.charset.Charset._isRegistered12354 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z");
			global::java.nio.charset.Charset._newDecoder12355 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.Charset._canEncode12356 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "canEncode", "()Z");
			global::java.nio.charset.Charset._Charset12357 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V");
		}
	}
}

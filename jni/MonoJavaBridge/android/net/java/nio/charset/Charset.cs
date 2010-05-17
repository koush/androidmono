namespace java.nio.charset 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Charset : java.lang.Object, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Charset() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.charset.Charset), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Charset(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _name11472; 
		public virtual java.lang.String name() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _name11472)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _name11472)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _forName11473; 
		public static java.nio.charset.Charset forName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, _forName11473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11474; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return @__env.CallIntMethod(this, _hashCode11474); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.charset.Charset.staticClass, _hashCode11474); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11475; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return @__env.CallBooleanMethod(this, _equals11475, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.Charset.staticClass, _equals11475, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11476; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return @__env.CallIntMethod(this, _compareTo11476, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.charset.Charset.staticClass, _compareTo11476, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11477; 
		public virtual int compareTo(java.nio.charset.Charset arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return @__env.CallIntMethod(this, _compareTo11477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.charset.Charset.staticClass, _compareTo11477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11478; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11478)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _toString11478)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _contains11479; 
		public abstract bool contains(java.nio.charset.Charset arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _decode11480; 
		public virtual java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _decode11480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _decode11480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode11481; 
		public virtual java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, _encode11481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _encode11481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode11482; 
		public virtual java.nio.ByteBuffer encode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, _encode11482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _encode11482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _defaultCharset11483; 
		public static java.nio.charset.Charset defaultCharset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, _defaultCharset11483)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSupported11484; 
		public static bool isSupported(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, _isSupported11484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newEncoder11485; 
		public abstract java.nio.charset.CharsetEncoder newEncoder(); 
		internal static global::net.sf.jni4net.jni.MethodId _aliases11486; 
		public virtual java.util.Set aliases() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _aliases11486)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _aliases11486)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _availableCharsets11487; 
		public static java.util.SortedMap availableCharsets() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.SortedMap>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.Charset.staticClass, _availableCharsets11487)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _displayName11488; 
		public virtual java.lang.String displayName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _displayName11488)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _displayName11488)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _displayName11489; 
		public virtual java.lang.String displayName(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _displayName11489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.Charset.staticClass, _displayName11489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered11490; 
		public virtual bool isRegistered() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return @__env.CallBooleanMethod(this, _isRegistered11490); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.Charset.staticClass, _isRegistered11490); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newDecoder11491; 
		public abstract java.nio.charset.CharsetDecoder newDecoder(); 
		internal static global::net.sf.jni4net.jni.MethodId _canEncode11492; 
		public virtual bool canEncode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.Charset)) 
				return @__env.CallBooleanMethod(this, _canEncode11492); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.Charset.staticClass, _canEncode11492); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Charset11493; 
		protected Charset(java.lang.String arg0, java.lang.String[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.charset.Charset.staticClass, _Charset11493, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.charset.Charset.staticClass = @__class; 
			global::java.nio.charset.Charset._name11472 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;"); 
			global::java.nio.charset.Charset._forName11473 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;"); 
			global::java.nio.charset.Charset._hashCode11474 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "hashCode", "()I"); 
			global::java.nio.charset.Charset._equals11475 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.charset.Charset._compareTo11476 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.charset.Charset._compareTo11477 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I"); 
			global::java.nio.charset.Charset._toString11478 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.charset.Charset._contains11479 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z"); 
			global::java.nio.charset.Charset._decode11480 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;"); 
			global::java.nio.charset.Charset._encode11481 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;"); 
			global::java.nio.charset.Charset._encode11482 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;"); 
			global::java.nio.charset.Charset._defaultCharset11483 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;"); 
			global::java.nio.charset.Charset._isSupported11484 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z"); 
			global::java.nio.charset.Charset._newEncoder11485 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;"); 
			global::java.nio.charset.Charset._aliases11486 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;"); 
			global::java.nio.charset.Charset._availableCharsets11487 = @__env.GetStaticMethodID(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;"); 
			global::java.nio.charset.Charset._displayName11488 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;"); 
			global::java.nio.charset.Charset._displayName11489 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.nio.charset.Charset._isRegistered11490 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z"); 
			global::java.nio.charset.Charset._newDecoder11491 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;"); 
			global::java.nio.charset.Charset._canEncode11492 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "canEncode", "()Z"); 
			global::java.nio.charset.Charset._Charset11493 = @__env.GetMethodID(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V"); 
		} 
	} 
} 

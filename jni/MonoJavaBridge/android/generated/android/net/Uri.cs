namespace android.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.net.Uri_))]
	public abstract partial class Uri : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Uri()
		{
			InitJNI();
		}
		protected Uri(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder()
			{
				InitJNI();
			}
			internal Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString7741;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._toString7741)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._toString7741)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _path7742;
			public global::android.net.Uri.Builder path(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._path7742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._path7742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _query7743;
			public global::android.net.Uri.Builder query(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._query7743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._query7743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _authority7744;
			public global::android.net.Uri.Builder authority(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._authority7744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._authority7744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _scheme7745;
			public global::android.net.Uri.Builder scheme(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._scheme7745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._scheme7745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _fragment7746;
			public global::android.net.Uri.Builder fragment(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._fragment7746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._fragment7746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _build7747;
			public global::android.net.Uri build() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._build7747)) as android.net.Uri;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._build7747)) as android.net.Uri;
			}
			internal static global::MonoJavaBridge.MethodId _opaquePart7748;
			public global::android.net.Uri.Builder opaquePart(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._opaquePart7748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._opaquePart7748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedOpaquePart7749;
			public global::android.net.Uri.Builder encodedOpaquePart(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedOpaquePart7749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedOpaquePart7749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedAuthority7750;
			public global::android.net.Uri.Builder encodedAuthority(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedAuthority7750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedAuthority7750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedPath7751;
			public global::android.net.Uri.Builder encodedPath(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedPath7751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedPath7751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendPath7752;
			public global::android.net.Uri.Builder appendPath(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._appendPath7752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendPath7752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendEncodedPath7753;
			public global::android.net.Uri.Builder appendEncodedPath(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._appendEncodedPath7753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendEncodedPath7753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedQuery7754;
			public global::android.net.Uri.Builder encodedQuery(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedQuery7754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedQuery7754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _encodedFragment7755;
			public global::android.net.Uri.Builder encodedFragment(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._encodedFragment7755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedFragment7755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _appendQueryParameter7756;
			public global::android.net.Uri.Builder appendQueryParameter(java.lang.String arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri.Builder._appendQueryParameter7756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendQueryParameter7756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _Builder7757;
			public Builder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._Builder7757);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.Uri.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri$Builder"));
				global::android.net.Uri.Builder._toString7741 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "toString", "()Ljava/lang/String;");
				global::android.net.Uri.Builder._path7742 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._query7743 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._authority7744 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._scheme7745 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._fragment7746 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._build7747 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "build", "()Landroid/net/Uri;");
				global::android.net.Uri.Builder._opaquePart7748 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedOpaquePart7749 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedAuthority7750 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedPath7751 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._appendPath7752 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._appendEncodedPath7753 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedQuery7754 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._encodedFragment7755 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._appendQueryParameter7756 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;");
				global::android.net.Uri.Builder._Builder7757 = @__env.GetMethodIDNoThrow(global::android.net.Uri.Builder.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7758;
		public abstract void writeToParcel(android.os.Parcel arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _describeContents7759;
		public abstract int describeContents();
		internal static global::MonoJavaBridge.MethodId _equals7760;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri._equals7760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._equals7760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7761;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode7762;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri._hashCode7762);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._hashCode7762);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo7763;
		public virtual int compareTo(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri._compareTo7763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._compareTo7763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo7764;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri._compareTo7764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._compareTo7764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decode7765;
		public static global::java.lang.String decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._decode7765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode7766;
		public static global::java.lang.String encode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._encode7766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode7767;
		public static global::java.lang.String encode(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._encode7767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute7768;
		public virtual bool isAbsolute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri._isAbsolute7768);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._isAbsolute7768);
		}
		internal static global::MonoJavaBridge.MethodId _getPath7769;
		public abstract global::java.lang.String getPath();
		internal static global::MonoJavaBridge.MethodId _isOpaque7770;
		public virtual bool isOpaque() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri._isOpaque7770);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._isOpaque7770);
		}
		internal static global::MonoJavaBridge.MethodId _getScheme7771;
		public abstract global::java.lang.String getScheme();
		internal static global::MonoJavaBridge.MethodId _getAuthority7772;
		public abstract global::java.lang.String getAuthority();
		internal static global::MonoJavaBridge.MethodId _getFragment7773;
		public abstract global::java.lang.String getFragment();
		internal static global::MonoJavaBridge.MethodId _getQuery7774;
		public abstract global::java.lang.String getQuery();
		internal static global::MonoJavaBridge.MethodId _parse7775;
		public static global::android.net.Uri parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._parse7775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo7776;
		public abstract global::java.lang.String getUserInfo();
		internal static global::MonoJavaBridge.MethodId _getPort7777;
		public abstract int getPort();
		internal static global::MonoJavaBridge.MethodId _getHost7778;
		public abstract global::java.lang.String getHost();
		internal static global::MonoJavaBridge.MethodId _writeToParcel7779;
		public static void writeToParcel(android.os.Parcel arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.net.Uri.staticClass, global::android.net.Uri._writeToParcel7779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isHierarchical7780;
		public abstract bool isHierarchical();
		internal static global::MonoJavaBridge.MethodId _isRelative7781;
		public abstract bool isRelative();
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart7782;
		public abstract global::java.lang.String getSchemeSpecificPart();
		internal static global::MonoJavaBridge.MethodId _getEncodedSchemeSpecificPart7783;
		public abstract global::java.lang.String getEncodedSchemeSpecificPart();
		internal static global::MonoJavaBridge.MethodId _getEncodedAuthority7784;
		public abstract global::java.lang.String getEncodedAuthority();
		internal static global::MonoJavaBridge.MethodId _getEncodedUserInfo7785;
		public abstract global::java.lang.String getEncodedUserInfo();
		internal static global::MonoJavaBridge.MethodId _getEncodedPath7786;
		public abstract global::java.lang.String getEncodedPath();
		internal static global::MonoJavaBridge.MethodId _getEncodedQuery7787;
		public abstract global::java.lang.String getEncodedQuery();
		internal static global::MonoJavaBridge.MethodId _getEncodedFragment7788;
		public abstract global::java.lang.String getEncodedFragment();
		internal static global::MonoJavaBridge.MethodId _getPathSegments7789;
		public abstract global::java.util.List getPathSegments();
		internal static global::MonoJavaBridge.MethodId _getLastPathSegment7790;
		public abstract global::java.lang.String getLastPathSegment();
		internal static global::MonoJavaBridge.MethodId _buildUpon7791;
		public abstract global::android.net.Uri.Builder buildUpon();
		internal static global::MonoJavaBridge.MethodId _fromFile7792;
		public static global::android.net.Uri fromFile(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._fromFile7792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _fromParts7793;
		public static global::android.net.Uri fromParts(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._fromParts7793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getQueryParameters7794;
		public virtual global::java.util.List getQueryParameters(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri._getQueryParameters7794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._getQueryParameters7794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getQueryParameter7795;
		public virtual global::java.lang.String getQueryParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri._getQueryParameter7795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri.staticClass, global::android.net.Uri._getQueryParameter7795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _withAppendedPath7796;
		public static global::android.net.Uri withAppendedPath(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.Uri.staticClass, global::android.net.Uri._withAppendedPath7796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY7797;
		public static global::android.net.Uri EMPTY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.net.Uri.staticClass, _EMPTY7797)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR7798;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.net.Uri.staticClass, _CREATOR7798)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
			global::android.net.Uri._writeToParcel7758 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.Uri._describeContents7759 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "describeContents", "()I");
			global::android.net.Uri._equals7760 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.net.Uri._toString7761 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.Uri._hashCode7762 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "hashCode", "()I");
			global::android.net.Uri._compareTo7763 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "compareTo", "(Landroid/net/Uri;)I");
			global::android.net.Uri._compareTo7764 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.net.Uri._decode7765 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._encode7766 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._encode7767 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._isAbsolute7768 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isAbsolute", "()Z");
			global::android.net.Uri._getPath7769 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.net.Uri._isOpaque7770 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isOpaque", "()Z");
			global::android.net.Uri._getScheme7771 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getScheme", "()Ljava/lang/String;");
			global::android.net.Uri._getAuthority7772 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::android.net.Uri._getFragment7773 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getFragment", "()Ljava/lang/String;");
			global::android.net.Uri._getQuery7774 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getQuery", "()Ljava/lang/String;");
			global::android.net.Uri._parse7775 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/Uri;");
			global::android.net.Uri._getUserInfo7776 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri._getPort7777 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getPort", "()I");
			global::android.net.Uri._getHost7778 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getHost", "()Ljava/lang/String;");
			global::android.net.Uri._writeToParcel7779 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V");
			global::android.net.Uri._isHierarchical7780 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isHierarchical", "()Z");
			global::android.net.Uri._isRelative7781 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "isRelative", "()Z");
			global::android.net.Uri._getSchemeSpecificPart7782 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedSchemeSpecificPart7783 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedAuthority7784 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedAuthority", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedUserInfo7785 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedPath7786 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedPath", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedQuery7787 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedQuery", "()Ljava/lang/String;");
			global::android.net.Uri._getEncodedFragment7788 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getEncodedFragment", "()Ljava/lang/String;");
			global::android.net.Uri._getPathSegments7789 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getPathSegments", "()Ljava/util/List;");
			global::android.net.Uri._getLastPathSegment7790 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getLastPathSegment", "()Ljava/lang/String;");
			global::android.net.Uri._buildUpon7791 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;");
			global::android.net.Uri._fromFile7792 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;");
			global::android.net.Uri._fromParts7793 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;");
			global::android.net.Uri._getQueryParameters7794 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;");
			global::android.net.Uri._getQueryParameter7795 = @__env.GetMethodIDNoThrow(global::android.net.Uri.staticClass, "getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.net.Uri._withAppendedPath7796 = @__env.GetStaticMethodIDNoThrow(global::android.net.Uri.staticClass, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;");
			global::android.net.Uri._EMPTY7797 = @__env.GetStaticFieldIDNoThrow(global::android.net.Uri.staticClass, "EMPTY", "Landroid/net/Uri;");
			global::android.net.Uri._CREATOR7798 = @__env.GetStaticFieldIDNoThrow(global::android.net.Uri.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.net.Uri))]
	public sealed partial class Uri_ : android.net.Uri
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Uri_()
		{
			InitJNI();
		}
		internal Uri_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7799;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.Uri_._writeToParcel7799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._writeToParcel7799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7800;
		public override int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri_._describeContents7800);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._describeContents7800);
		}
		internal static global::MonoJavaBridge.MethodId _toString7801;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._toString7801)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._toString7801)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath7802;
		public override global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getPath7802)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getPath7802)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme7803;
		public override global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getScheme7803)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getScheme7803)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority7804;
		public override global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getAuthority7804)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getAuthority7804)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFragment7805;
		public override global::java.lang.String getFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getFragment7805)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getFragment7805)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuery7806;
		public override global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getQuery7806)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getQuery7806)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo7807;
		public override global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getUserInfo7807)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getUserInfo7807)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPort7808;
		public override int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Uri_._getPort7808);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getPort7808);
		}
		internal static global::MonoJavaBridge.MethodId _getHost7809;
		public override global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getHost7809)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getHost7809)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isHierarchical7810;
		public override bool isHierarchical() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri_._isHierarchical7810);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._isHierarchical7810);
		}
		internal static global::MonoJavaBridge.MethodId _isRelative7811;
		public override bool isRelative() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.Uri_._isRelative7811);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._isRelative7811);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeSpecificPart7812;
		public override global::java.lang.String getSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getSchemeSpecificPart7812)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getSchemeSpecificPart7812)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedSchemeSpecificPart7813;
		public override global::java.lang.String getEncodedSchemeSpecificPart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedSchemeSpecificPart7813)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedSchemeSpecificPart7813)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedAuthority7814;
		public override global::java.lang.String getEncodedAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedAuthority7814)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedAuthority7814)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedUserInfo7815;
		public override global::java.lang.String getEncodedUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedUserInfo7815)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedUserInfo7815)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedPath7816;
		public override global::java.lang.String getEncodedPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedPath7816)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedPath7816)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedQuery7817;
		public override global::java.lang.String getEncodedQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedQuery7817)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedQuery7817)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedFragment7818;
		public override global::java.lang.String getEncodedFragment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getEncodedFragment7818)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getEncodedFragment7818)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPathSegments7819;
		public override global::java.util.List getPathSegments() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getPathSegments7819)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getPathSegments7819)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getLastPathSegment7820;
		public override global::java.lang.String getLastPathSegment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._getLastPathSegment7820)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._getLastPathSegment7820)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUpon7821;
		public override global::android.net.Uri.Builder buildUpon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.Uri_._buildUpon7821)) as android.net.Uri.Builder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.Uri_.staticClass, global::android.net.Uri_._buildUpon7821)) as android.net.Uri.Builder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Uri_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Uri"));
			global::android.net.Uri_._writeToParcel7799 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.Uri_._describeContents7800 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "describeContents", "()I");
			global::android.net.Uri_._toString7801 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.Uri_._getPath7802 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.net.Uri_._getScheme7803 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getScheme", "()Ljava/lang/String;");
			global::android.net.Uri_._getAuthority7804 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::android.net.Uri_._getFragment7805 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getFragment", "()Ljava/lang/String;");
			global::android.net.Uri_._getQuery7806 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getQuery", "()Ljava/lang/String;");
			global::android.net.Uri_._getUserInfo7807 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri_._getPort7808 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getPort", "()I");
			global::android.net.Uri_._getHost7809 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getHost", "()Ljava/lang/String;");
			global::android.net.Uri_._isHierarchical7810 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "isHierarchical", "()Z");
			global::android.net.Uri_._isRelative7811 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "isRelative", "()Z");
			global::android.net.Uri_._getSchemeSpecificPart7812 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedSchemeSpecificPart7813 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedAuthority7814 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedAuthority", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedUserInfo7815 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedPath7816 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedPath", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedQuery7817 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedQuery", "()Ljava/lang/String;");
			global::android.net.Uri_._getEncodedFragment7818 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getEncodedFragment", "()Ljava/lang/String;");
			global::android.net.Uri_._getPathSegments7819 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getPathSegments", "()Ljava/util/List;");
			global::android.net.Uri_._getLastPathSegment7820 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "getLastPathSegment", "()Ljava/lang/String;");
			global::android.net.Uri_._buildUpon7821 = @__env.GetMethodIDNoThrow(global::android.net.Uri_.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;");
		}
	}
}

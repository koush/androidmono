namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Uri : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Uri() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.Uri), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Uri(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Builder : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Builder() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.Uri.Builder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.Uri.Builder(@__env); 
				} 
			} 
			internal Builder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString4490; 
			public sealed override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4490)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _toString4490)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _path4491; 
			public android.net.Uri.Builder path(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _path4491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _path4491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _query4492; 
			public android.net.Uri.Builder query(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _query4492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _query4492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _authority4493; 
			public android.net.Uri.Builder authority(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _authority4493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _authority4493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _scheme4494; 
			public android.net.Uri.Builder scheme(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _scheme4494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _scheme4494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _fragment4495; 
			public android.net.Uri.Builder fragment(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _fragment4495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _fragment4495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _build4496; 
			public android.net.Uri build() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _build4496)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _build4496)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _opaquePart4497; 
			public android.net.Uri.Builder opaquePart(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _opaquePart4497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _opaquePart4497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedOpaquePart4498; 
			public android.net.Uri.Builder encodedOpaquePart(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _encodedOpaquePart4498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _encodedOpaquePart4498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedAuthority4499; 
			public android.net.Uri.Builder encodedAuthority(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _encodedAuthority4499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _encodedAuthority4499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedPath4500; 
			public android.net.Uri.Builder encodedPath(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _encodedPath4500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _encodedPath4500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appendPath4501; 
			public android.net.Uri.Builder appendPath(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _appendPath4501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _appendPath4501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appendEncodedPath4502; 
			public android.net.Uri.Builder appendEncodedPath(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _appendEncodedPath4502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _appendEncodedPath4502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedQuery4503; 
			public android.net.Uri.Builder encodedQuery(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _encodedQuery4503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _encodedQuery4503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedFragment4504; 
			public android.net.Uri.Builder encodedFragment(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _encodedFragment4504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _encodedFragment4504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appendQueryParameter4505; 
			public android.net.Uri.Builder appendQueryParameter(java.lang.String arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, _appendQueryParameter4505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.Builder.staticClass, _appendQueryParameter4505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Builder4506; 
			public Builder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.Uri.Builder.staticClass, _Builder4506, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.Uri.Builder.staticClass = @__class; 
				global::android.net.Uri.Builder._toString4490 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.net.Uri.Builder._path4491 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._query4492 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._authority4493 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._scheme4494 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._fragment4495 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._build4496 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "build", "()Landroid/net/Uri;"); 
				global::android.net.Uri.Builder._opaquePart4497 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedOpaquePart4498 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedAuthority4499 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedPath4500 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._appendPath4501 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._appendEncodedPath4502 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedQuery4503 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedFragment4504 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._appendQueryParameter4505 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._Builder4506 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4507; 
		public abstract void writeToParcel(android.os.Parcel arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4508; 
		public abstract int describeContents(); 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode4509; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallIntMethod(this, _hashCode4509); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Uri.staticClass, _hashCode4509); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals4510; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallBooleanMethod(this, _equals4510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.Uri.staticClass, _equals4510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo4511; 
		public virtual int compareTo(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallIntMethod(this, _compareTo4511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Uri.staticClass, _compareTo4511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo4512; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallIntMethod(this, _compareTo4512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Uri.staticClass, _compareTo4512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4513; 
		public abstract new java.lang.String toString(); 
		internal static global::net.sf.jni4net.jni.MethodId _decode4514; 
		public static java.lang.String decode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _decode4514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode4515; 
		public static java.lang.String encode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _encode4515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode4516; 
		public static java.lang.String encode(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _encode4516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAbsolute4517; 
		public virtual bool isAbsolute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallBooleanMethod(this, _isAbsolute4517); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.Uri.staticClass, _isAbsolute4517); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath4518; 
		public abstract java.lang.String getPath(); 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque4519; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallBooleanMethod(this, _isOpaque4519); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.Uri.staticClass, _isOpaque4519); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScheme4520; 
		public abstract java.lang.String getScheme(); 
		internal static global::net.sf.jni4net.jni.MethodId _getAuthority4521; 
		public abstract java.lang.String getAuthority(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFragment4522; 
		public abstract java.lang.String getFragment(); 
		internal static global::net.sf.jni4net.jni.MethodId _getQuery4523; 
		public abstract java.lang.String getQuery(); 
		internal static global::net.sf.jni4net.jni.MethodId _parse4524; 
		public static android.net.Uri parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _parse4524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserInfo4525; 
		public abstract java.lang.String getUserInfo(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPort4526; 
		public abstract int getPort(); 
		internal static global::net.sf.jni4net.jni.MethodId _getHost4527; 
		public abstract java.lang.String getHost(); 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4528; 
		public static void writeToParcel(android.os.Parcel arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.net.Uri.staticClass, _writeToParcel4528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHierarchical4529; 
		public abstract bool isHierarchical(); 
		internal static global::net.sf.jni4net.jni.MethodId _isRelative4530; 
		public abstract bool isRelative(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeSpecificPart4531; 
		public abstract java.lang.String getSchemeSpecificPart(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedSchemeSpecificPart4532; 
		public abstract java.lang.String getEncodedSchemeSpecificPart(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedAuthority4533; 
		public abstract java.lang.String getEncodedAuthority(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedUserInfo4534; 
		public abstract java.lang.String getEncodedUserInfo(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedPath4535; 
		public abstract java.lang.String getEncodedPath(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedQuery4536; 
		public abstract java.lang.String getEncodedQuery(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedFragment4537; 
		public abstract java.lang.String getEncodedFragment(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPathSegments4538; 
		public abstract java.util.List getPathSegments(); 
		internal static global::net.sf.jni4net.jni.MethodId _getLastPathSegment4539; 
		public abstract java.lang.String getLastPathSegment(); 
		internal static global::net.sf.jni4net.jni.MethodId _buildUpon4540; 
		public abstract android.net.Uri.Builder buildUpon(); 
		internal static global::net.sf.jni4net.jni.MethodId _fromFile4541; 
		public static android.net.Uri fromFile(java.io.File arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _fromFile4541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromParts4542; 
		public static android.net.Uri fromParts(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _fromParts4542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQueryParameters4543; 
		public virtual java.util.List getQueryParameters(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getQueryParameters4543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.staticClass, _getQueryParameters4543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQueryParameter4544; 
		public virtual java.lang.String getQueryParameter(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getQueryParameter4544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.Uri.staticClass, _getQueryParameter4544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _withAppendedPath4545; 
		public static android.net.Uri withAppendedPath(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, _withAppendedPath4545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY4546; 
		public static android.net.Uri EMPTY
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4547; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.Uri.staticClass = @__class; 
			global::android.net.Uri._writeToParcel4507 = @__env.GetMethodID(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.Uri._describeContents4508 = @__env.GetMethodID(global::android.net.Uri.staticClass, "describeContents", "()I"); 
			global::android.net.Uri._hashCode4509 = @__env.GetMethodID(global::android.net.Uri.staticClass, "hashCode", "()I"); 
			global::android.net.Uri._equals4510 = @__env.GetMethodID(global::android.net.Uri.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.net.Uri._compareTo4511 = @__env.GetMethodID(global::android.net.Uri.staticClass, "compareTo", "(Landroid/net/Uri;)I"); 
			global::android.net.Uri._compareTo4512 = @__env.GetMethodID(global::android.net.Uri.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::android.net.Uri._toString4513 = @__env.GetMethodID(global::android.net.Uri.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.Uri._decode4514 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._encode4515 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._encode4516 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._isAbsolute4517 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isAbsolute", "()Z"); 
			global::android.net.Uri._getPath4518 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::android.net.Uri._isOpaque4519 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isOpaque", "()Z"); 
			global::android.net.Uri._getScheme4520 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getScheme", "()Ljava/lang/String;"); 
			global::android.net.Uri._getAuthority4521 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getAuthority", "()Ljava/lang/String;"); 
			global::android.net.Uri._getFragment4522 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getFragment", "()Ljava/lang/String;"); 
			global::android.net.Uri._getQuery4523 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getQuery", "()Ljava/lang/String;"); 
			global::android.net.Uri._parse4524 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/Uri;"); 
			global::android.net.Uri._getUserInfo4525 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getUserInfo", "()Ljava/lang/String;"); 
			global::android.net.Uri._getPort4526 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getPort", "()I"); 
			global::android.net.Uri._getHost4527 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getHost", "()Ljava/lang/String;"); 
			global::android.net.Uri._writeToParcel4528 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V"); 
			global::android.net.Uri._isHierarchical4529 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isHierarchical", "()Z"); 
			global::android.net.Uri._isRelative4530 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isRelative", "()Z"); 
			global::android.net.Uri._getSchemeSpecificPart4531 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedSchemeSpecificPart4532 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedAuthority4533 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedAuthority", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedUserInfo4534 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedPath4535 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedPath", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedQuery4536 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedQuery", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedFragment4537 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedFragment", "()Ljava/lang/String;"); 
			global::android.net.Uri._getPathSegments4538 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getPathSegments", "()Ljava/util/List;"); 
			global::android.net.Uri._getLastPathSegment4539 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getLastPathSegment", "()Ljava/lang/String;"); 
			global::android.net.Uri._buildUpon4540 = @__env.GetMethodID(global::android.net.Uri.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;"); 
			global::android.net.Uri._fromFile4541 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;"); 
			global::android.net.Uri._fromParts4542 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;"); 
			global::android.net.Uri._getQueryParameters4543 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;"); 
			global::android.net.Uri._getQueryParameter4544 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._withAppendedPath4545 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;"); 
		} 
	} 
} 

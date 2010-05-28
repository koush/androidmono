namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Uri : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Uri() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.Uri), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.Uri.Builder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString4738; 
			public sealed override global::java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._toString4738)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._toString4738)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _path4739; 
			public global::android.net.Uri.Builder path(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._path4739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._path4739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _query4740; 
			public global::android.net.Uri.Builder query(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._query4740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._query4740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _authority4741; 
			public global::android.net.Uri.Builder authority(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._authority4741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._authority4741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _scheme4742; 
			public global::android.net.Uri.Builder scheme(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._scheme4742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._scheme4742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _fragment4743; 
			public global::android.net.Uri.Builder fragment(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._fragment4743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._fragment4743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _build4744; 
			public global::android.net.Uri build() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._build4744)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._build4744)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _opaquePart4745; 
			public global::android.net.Uri.Builder opaquePart(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._opaquePart4745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._opaquePart4745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedOpaquePart4746; 
			public global::android.net.Uri.Builder encodedOpaquePart(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._encodedOpaquePart4746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedOpaquePart4746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedAuthority4747; 
			public global::android.net.Uri.Builder encodedAuthority(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._encodedAuthority4747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedAuthority4747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedPath4748; 
			public global::android.net.Uri.Builder encodedPath(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._encodedPath4748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedPath4748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appendPath4749; 
			public global::android.net.Uri.Builder appendPath(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._appendPath4749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendPath4749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appendEncodedPath4750; 
			public global::android.net.Uri.Builder appendEncodedPath(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._appendEncodedPath4750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendEncodedPath4750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedQuery4751; 
			public global::android.net.Uri.Builder encodedQuery(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._encodedQuery4751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedQuery4751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _encodedFragment4752; 
			public global::android.net.Uri.Builder encodedFragment(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._encodedFragment4752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._encodedFragment4752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _appendQueryParameter4753; 
			public global::android.net.Uri.Builder appendQueryParameter(java.lang.String arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.net.Uri.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri.Builder._appendQueryParameter4753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._appendQueryParameter4753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Builder4754; 
			public Builder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.net.Uri.Builder.staticClass, global::android.net.Uri.Builder._Builder4754, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.Uri.Builder.staticClass = @__class; 
				global::android.net.Uri.Builder._toString4738 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.net.Uri.Builder._path4739 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._query4740 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._authority4741 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._scheme4742 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._fragment4743 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._build4744 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "build", "()Landroid/net/Uri;"); 
				global::android.net.Uri.Builder._opaquePart4745 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedOpaquePart4746 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedAuthority4747 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedPath4748 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._appendPath4749 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._appendEncodedPath4750 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedQuery4751 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._encodedFragment4752 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._appendQueryParameter4753 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;"); 
				global::android.net.Uri.Builder._Builder4754 = @__env.GetMethodID(global::android.net.Uri.Builder.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4755; 
		public abstract void writeToParcel(android.os.Parcel arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4756; 
		public abstract int describeContents(); 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode4757; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallIntMethod(this, global::android.net.Uri._hashCode4757); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.Uri.staticClass, global::android.net.Uri._hashCode4757); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals4758; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallBooleanMethod(this, global::android.net.Uri._equals4758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.Uri.staticClass, global::android.net.Uri._equals4758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo4759; 
		public virtual int compareTo(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallIntMethod(this, global::android.net.Uri._compareTo4759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.Uri.staticClass, global::android.net.Uri._compareTo4759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo4760; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallIntMethod(this, global::android.net.Uri._compareTo4760, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.Uri.staticClass, global::android.net.Uri._compareTo4760, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4761; 
		public abstract new global::java.lang.String toString(); 
		internal static global::net.sf.jni4net.jni.MethodId _decode4762; 
		public static global::java.lang.String decode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._decode4762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode4763; 
		public static global::java.lang.String encode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._encode4763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode4764; 
		public static global::java.lang.String encode(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._encode4764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAbsolute4765; 
		public virtual bool isAbsolute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallBooleanMethod(this, global::android.net.Uri._isAbsolute4765); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.Uri.staticClass, global::android.net.Uri._isAbsolute4765); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath4766; 
		public abstract global::java.lang.String getPath(); 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque4767; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return @__env.CallBooleanMethod(this, global::android.net.Uri._isOpaque4767); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.Uri.staticClass, global::android.net.Uri._isOpaque4767); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScheme4768; 
		public abstract global::java.lang.String getScheme(); 
		internal static global::net.sf.jni4net.jni.MethodId _getAuthority4769; 
		public abstract global::java.lang.String getAuthority(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFragment4770; 
		public abstract global::java.lang.String getFragment(); 
		internal static global::net.sf.jni4net.jni.MethodId _getQuery4771; 
		public abstract global::java.lang.String getQuery(); 
		internal static global::net.sf.jni4net.jni.MethodId _parse4772; 
		public static global::android.net.Uri parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._parse4772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserInfo4773; 
		public abstract global::java.lang.String getUserInfo(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPort4774; 
		public abstract int getPort(); 
		internal static global::net.sf.jni4net.jni.MethodId _getHost4775; 
		public abstract global::java.lang.String getHost(); 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4776; 
		public static void writeToParcel(android.os.Parcel arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.net.Uri.staticClass, global::android.net.Uri._writeToParcel4776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isHierarchical4777; 
		public abstract bool isHierarchical(); 
		internal static global::net.sf.jni4net.jni.MethodId _isRelative4778; 
		public abstract bool isRelative(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeSpecificPart4779; 
		public abstract global::java.lang.String getSchemeSpecificPart(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedSchemeSpecificPart4780; 
		public abstract global::java.lang.String getEncodedSchemeSpecificPart(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedAuthority4781; 
		public abstract global::java.lang.String getEncodedAuthority(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedUserInfo4782; 
		public abstract global::java.lang.String getEncodedUserInfo(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedPath4783; 
		public abstract global::java.lang.String getEncodedPath(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedQuery4784; 
		public abstract global::java.lang.String getEncodedQuery(); 
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedFragment4785; 
		public abstract global::java.lang.String getEncodedFragment(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPathSegments4786; 
		public abstract global::java.util.List getPathSegments(); 
		internal static global::net.sf.jni4net.jni.MethodId _getLastPathSegment4787; 
		public abstract global::java.lang.String getLastPathSegment(); 
		internal static global::net.sf.jni4net.jni.MethodId _buildUpon4788; 
		public abstract global::android.net.Uri.Builder buildUpon(); 
		internal static global::net.sf.jni4net.jni.MethodId _fromFile4789; 
		public static global::android.net.Uri fromFile(java.io.File arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._fromFile4789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromParts4790; 
		public static global::android.net.Uri fromParts(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._fromParts4790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQueryParameters4791; 
		public virtual global::java.util.List getQueryParameters(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri._getQueryParameters4791, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.staticClass, global::android.net.Uri._getQueryParameters4791, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getQueryParameter4792; 
		public virtual global::java.lang.String getQueryParameter(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Uri)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.Uri._getQueryParameter4792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.Uri.staticClass, global::android.net.Uri._getQueryParameter4792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _withAppendedPath4793; 
		public static global::android.net.Uri withAppendedPath(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallStaticObjectMethodPtr(android.net.Uri.staticClass, global::android.net.Uri._withAppendedPath4793, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY4794; 
		public static global::android.net.Uri EMPTY
		{ 
			get 
			{ 
				return default(global::android.net.Uri); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4795; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.Uri.staticClass = @__class; 
			global::android.net.Uri._writeToParcel4755 = @__env.GetMethodID(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.Uri._describeContents4756 = @__env.GetMethodID(global::android.net.Uri.staticClass, "describeContents", "()I"); 
			global::android.net.Uri._hashCode4757 = @__env.GetMethodID(global::android.net.Uri.staticClass, "hashCode", "()I"); 
			global::android.net.Uri._equals4758 = @__env.GetMethodID(global::android.net.Uri.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.net.Uri._compareTo4759 = @__env.GetMethodID(global::android.net.Uri.staticClass, "compareTo", "(Landroid/net/Uri;)I"); 
			global::android.net.Uri._compareTo4760 = @__env.GetMethodID(global::android.net.Uri.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::android.net.Uri._toString4761 = @__env.GetMethodID(global::android.net.Uri.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.Uri._decode4762 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._encode4763 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._encode4764 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._isAbsolute4765 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isAbsolute", "()Z"); 
			global::android.net.Uri._getPath4766 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::android.net.Uri._isOpaque4767 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isOpaque", "()Z"); 
			global::android.net.Uri._getScheme4768 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getScheme", "()Ljava/lang/String;"); 
			global::android.net.Uri._getAuthority4769 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getAuthority", "()Ljava/lang/String;"); 
			global::android.net.Uri._getFragment4770 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getFragment", "()Ljava/lang/String;"); 
			global::android.net.Uri._getQuery4771 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getQuery", "()Ljava/lang/String;"); 
			global::android.net.Uri._parse4772 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "parse", "(Ljava/lang/String;)Landroid/net/Uri;"); 
			global::android.net.Uri._getUserInfo4773 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getUserInfo", "()Ljava/lang/String;"); 
			global::android.net.Uri._getPort4774 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getPort", "()I"); 
			global::android.net.Uri._getHost4775 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getHost", "()Ljava/lang/String;"); 
			global::android.net.Uri._writeToParcel4776 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V"); 
			global::android.net.Uri._isHierarchical4777 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isHierarchical", "()Z"); 
			global::android.net.Uri._isRelative4778 = @__env.GetMethodID(global::android.net.Uri.staticClass, "isRelative", "()Z"); 
			global::android.net.Uri._getSchemeSpecificPart4779 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedSchemeSpecificPart4780 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedSchemeSpecificPart", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedAuthority4781 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedAuthority", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedUserInfo4782 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedUserInfo", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedPath4783 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedPath", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedQuery4784 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedQuery", "()Ljava/lang/String;"); 
			global::android.net.Uri._getEncodedFragment4785 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getEncodedFragment", "()Ljava/lang/String;"); 
			global::android.net.Uri._getPathSegments4786 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getPathSegments", "()Ljava/util/List;"); 
			global::android.net.Uri._getLastPathSegment4787 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getLastPathSegment", "()Ljava/lang/String;"); 
			global::android.net.Uri._buildUpon4788 = @__env.GetMethodID(global::android.net.Uri.staticClass, "buildUpon", "()Landroid/net/Uri$Builder;"); 
			global::android.net.Uri._fromFile4789 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "fromFile", "(Ljava/io/File;)Landroid/net/Uri;"); 
			global::android.net.Uri._fromParts4790 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;"); 
			global::android.net.Uri._getQueryParameters4791 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;"); 
			global::android.net.Uri._getQueryParameter4792 = @__env.GetMethodID(global::android.net.Uri.staticClass, "getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.net.Uri._withAppendedPath4793 = @__env.GetStaticMethodID(global::android.net.Uri.staticClass, "withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;"); 
		} 
	} 
} 

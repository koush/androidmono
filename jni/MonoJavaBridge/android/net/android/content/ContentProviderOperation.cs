namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContentProviderOperation : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentProviderOperation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentProviderOperation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ContentProviderOperation(@__env); 
			} 
		} 
		protected ContentProviderOperation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Builder : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Builder() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentProviderOperation.Builder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.ContentProviderOperation.Builder(@__env); 
				} 
			} 
			protected Builder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _build998; 
			public virtual android.content.ContentProviderOperation build() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallObjectMethodPtr(this, _build998)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _build998)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withValueBackReferences999; 
			public virtual android.content.ContentProviderOperation.Builder withValueBackReferences(android.content.ContentValues arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withValueBackReferences999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withValueBackReferences999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withValueBackReference1000; 
			public virtual android.content.ContentProviderOperation.Builder withValueBackReference(java.lang.String arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withValueBackReference1000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withValueBackReference1000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withSelectionBackReference1001; 
			public virtual android.content.ContentProviderOperation.Builder withSelectionBackReference(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withSelectionBackReference1001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withSelectionBackReference1001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withValues1002; 
			public virtual android.content.ContentProviderOperation.Builder withValues(android.content.ContentValues arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withValues1002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withValues1002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withValue1003; 
			public virtual android.content.ContentProviderOperation.Builder withValue(java.lang.String arg0, java.lang.Object arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withValue1003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withValue1003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withSelection1004; 
			public virtual android.content.ContentProviderOperation.Builder withSelection(java.lang.String arg0, java.lang.String[] arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withSelection1004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withSelection1004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withExpectedCount1005; 
			public virtual android.content.ContentProviderOperation.Builder withExpectedCount(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withExpectedCount1005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withExpectedCount1005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _withYieldAllowed1006; 
			public virtual android.content.ContentProviderOperation.Builder withYieldAllowed(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.ContentProviderOperation.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallObjectMethodPtr(this, _withYieldAllowed1006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.Builder.staticClass, _withYieldAllowed1006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.ContentProviderOperation.Builder.staticClass = @__class; 
				global::android.content.ContentProviderOperation.Builder._build998 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "build", "()Landroid/content/ContentProviderOperation;"); 
				global::android.content.ContentProviderOperation.Builder._withValueBackReferences999 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withValueBackReference1000 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withSelectionBackReference1001 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withValues1002 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withValue1003 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withSelection1004 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withExpectedCount1005 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;"); 
				global::android.content.ContentProviderOperation.Builder._withYieldAllowed1006 = @__env.GetMethodID(global::android.content.ContentProviderOperation.Builder.staticClass, "withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUri1007; 
		public virtual android.net.Uri getUri() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _getUri1007)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.staticClass, _getUri1007)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1008; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				@__env.CallVoidMethod(this, _writeToParcel1008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProviderOperation.staticClass, _writeToParcel1008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1009; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return @__env.CallIntMethod(this, _describeContents1009); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProviderOperation.staticClass, _describeContents1009); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _apply1010; 
		public virtual android.content.ContentProviderResult apply(android.content.ContentProvider arg0, android.content.ContentProviderResult[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderResult>(@__env, @__env.CallObjectMethodPtr(this, _apply1010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.staticClass, _apply1010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newInsert1011; 
		public static android.content.ContentProviderOperation.Builder newInsert(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, _newInsert1011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newUpdate1012; 
		public static android.content.ContentProviderOperation.Builder newUpdate(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, _newUpdate1012, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newDelete1013; 
		public static android.content.ContentProviderOperation.Builder newDelete(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, _newDelete1013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newAssertQuery1014; 
		public static android.content.ContentProviderOperation.Builder newAssertQuery(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentProviderOperation.Builder>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ContentProviderOperation.staticClass, _newAssertQuery1014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isYieldAllowed1015; 
		public virtual bool isYieldAllowed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return @__env.CallBooleanMethod(this, _isYieldAllowed1015); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentProviderOperation.staticClass, _isYieldAllowed1015); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWriteOperation1016; 
		public virtual bool isWriteOperation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return @__env.CallBooleanMethod(this, _isWriteOperation1016); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentProviderOperation.staticClass, _isWriteOperation1016); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReadOperation1017; 
		public virtual bool isReadOperation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return @__env.CallBooleanMethod(this, _isReadOperation1017); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentProviderOperation.staticClass, _isReadOperation1017); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveValueBackReferences1018; 
		public virtual android.content.ContentValues resolveValueBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallObjectMethodPtr(this, _resolveValueBackReferences1018, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.staticClass, _resolveValueBackReferences1018, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveSelectionArgsBackReferences1019; 
		public virtual java.lang.String[] resolveSelectionArgsBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{ 
			if (GetType() == typeof(android.content.ContentProviderOperation)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _resolveSelectionArgsBackReferences1019, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderOperation.staticClass, _resolveSelectionArgsBackReferences1019, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1020; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentProviderOperation.staticClass = @__class; 
			global::android.content.ContentProviderOperation._getUri1007 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "getUri", "()Landroid/net/Uri;"); 
			global::android.content.ContentProviderOperation._writeToParcel1008 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.ContentProviderOperation._describeContents1009 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "describeContents", "()I"); 
			global::android.content.ContentProviderOperation._apply1010 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landroid/content/ContentProviderResult;"); 
			global::android.content.ContentProviderOperation._newInsert1011 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;"); 
			global::android.content.ContentProviderOperation._newUpdate1012 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;"); 
			global::android.content.ContentProviderOperation._newDelete1013 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;"); 
			global::android.content.ContentProviderOperation._newAssertQuery1014 = @__env.GetStaticMethodID(global::android.content.ContentProviderOperation.staticClass, "newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;"); 
			global::android.content.ContentProviderOperation._isYieldAllowed1015 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isYieldAllowed", "()Z"); 
			global::android.content.ContentProviderOperation._isWriteOperation1016 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isWriteOperation", "()Z"); 
			global::android.content.ContentProviderOperation._isReadOperation1017 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "isReadOperation", "()Z"); 
			global::android.content.ContentProviderOperation._resolveValueBackReferences1018 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;"); 
			global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences1019 = @__env.GetMethodID(global::android.content.ContentProviderOperation.staticClass, "resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;"); 
		} 
	} 
} 

namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderOperation : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentProviderOperation()
		{
			InitJNI();
		}
		protected ContentProviderOperation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder()
			{
				InitJNI();
			}
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _build2665;
			public virtual global::android.content.ContentProviderOperation build() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._build2665)) as android.content.ContentProviderOperation;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._build2665)) as android.content.ContentProviderOperation;
			}
			internal static global::MonoJavaBridge.MethodId _withValueBackReferences2666;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReferences(android.content.ContentValues arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValueBackReferences2666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReferences2666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withValueBackReference2667;
			public virtual global::android.content.ContentProviderOperation.Builder withValueBackReference(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValueBackReference2667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValueBackReference2667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withSelectionBackReference2668;
			public virtual global::android.content.ContentProviderOperation.Builder withSelectionBackReference(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference2668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelectionBackReference2668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withValues2669;
			public virtual global::android.content.ContentProviderOperation.Builder withValues(android.content.ContentValues arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValues2669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValues2669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withValue2670;
			public virtual global::android.content.ContentProviderOperation.Builder withValue(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withValue2670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withValue2670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withSelection2671;
			public virtual global::android.content.ContentProviderOperation.Builder withSelection(java.lang.String arg0, java.lang.String[] arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withSelection2671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withSelection2671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withExpectedCount2672;
			public virtual global::android.content.ContentProviderOperation.Builder withExpectedCount(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withExpectedCount2672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withExpectedCount2672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _withYieldAllowed2673;
			public virtual global::android.content.ContentProviderOperation.Builder withYieldAllowed(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder._withYieldAllowed2673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.Builder.staticClass, global::android.content.ContentProviderOperation.Builder._withYieldAllowed2673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.ContentProviderOperation.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderOperation$Builder"));
				global::android.content.ContentProviderOperation.Builder._build2665 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "build", "()Landroid/content/ContentProviderOperation;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReferences2666 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValueBackReference2667 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelectionBackReference2668 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValues2669 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withValue2670 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withSelection2671 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withExpectedCount2672 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;");
				global::android.content.ContentProviderOperation.Builder._withYieldAllowed2673 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.Builder.staticClass, "withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString2674;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._toString2674)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._toString2674)) as java.lang.String;
		}
		public new global::android.net.Uri Uri
		{
			get
			{
				return getUri();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUri2675;
		public virtual global::android.net.Uri getUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._getUri2675)) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._getUri2675)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2676;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProviderOperation._writeToParcel2676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._writeToParcel2676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2677;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderOperation._describeContents2677);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._describeContents2677);
		}
		internal static global::MonoJavaBridge.MethodId _apply2678;
		public virtual global::android.content.ContentProviderResult apply(android.content.ContentProvider arg0, android.content.ContentProviderResult[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._apply2678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._apply2678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.ContentProviderResult;
		}
		internal static global::MonoJavaBridge.MethodId _newInsert2679;
		public static global::android.content.ContentProviderOperation.Builder newInsert(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newInsert2679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _newUpdate2680;
		public static global::android.content.ContentProviderOperation.Builder newUpdate(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newUpdate2680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _newDelete2681;
		public static global::android.content.ContentProviderOperation.Builder newDelete(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newDelete2681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _newAssertQuery2682;
		public static global::android.content.ContentProviderOperation.Builder newAssertQuery(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._newAssertQuery2682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderOperation.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _isYieldAllowed2683;
		public virtual bool isYieldAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation._isYieldAllowed2683);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isYieldAllowed2683);
		}
		internal static global::MonoJavaBridge.MethodId _isWriteOperation2684;
		public virtual bool isWriteOperation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation._isWriteOperation2684);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isWriteOperation2684);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOperation2685;
		public virtual bool isReadOperation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation._isReadOperation2685);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._isReadOperation2685);
		}
		internal static global::MonoJavaBridge.MethodId _resolveValueBackReferences2686;
		public virtual global::android.content.ContentValues resolveValueBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._resolveValueBackReferences2686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentValues;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveValueBackReferences2686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentValues;
		}
		internal static global::MonoJavaBridge.MethodId _resolveSelectionArgsBackReferences2687;
		public virtual global::java.lang.String[] resolveSelectionArgsBackReferences(android.content.ContentProviderResult[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences2687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderOperation.staticClass, global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences2687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2688;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentProviderOperation.staticClass, _CREATOR2688)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProviderOperation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderOperation"));
			global::android.content.ContentProviderOperation._toString2674 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentProviderOperation._getUri2675 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "getUri", "()Landroid/net/Uri;");
			global::android.content.ContentProviderOperation._writeToParcel2676 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderOperation._describeContents2677 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderOperation._apply2678 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landroid/content/ContentProviderResult;");
			global::android.content.ContentProviderOperation._newInsert2679 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newUpdate2680 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newDelete2681 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._newAssertQuery2682 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;");
			global::android.content.ContentProviderOperation._isYieldAllowed2683 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "isYieldAllowed", "()Z");
			global::android.content.ContentProviderOperation._isWriteOperation2684 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "isWriteOperation", "()Z");
			global::android.content.ContentProviderOperation._isReadOperation2685 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "isReadOperation", "()Z");
			global::android.content.ContentProviderOperation._resolveValueBackReferences2686 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;");
			global::android.content.ContentProviderOperation._resolveSelectionArgsBackReferences2687 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;");
			global::android.content.ContentProviderOperation._CREATOR2688 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentProviderOperation.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}

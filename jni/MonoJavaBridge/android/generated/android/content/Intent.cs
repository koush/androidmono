namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Intent : java.lang.Object, android.os.Parcelable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Intent()
		{
			InitJNI();
		}
		protected Intent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class FilterComparison : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterComparison()
			{
				InitJNI();
			}
			internal FilterComparison(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals1530;
			public sealed override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent.FilterComparison._equals1530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._equals1530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _hashCode1531;
			public sealed override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent.FilterComparison._hashCode1531);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._hashCode1531);
			}
			internal static global::MonoJavaBridge.MethodId _getIntent1532;
			public global::android.content.Intent getIntent() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent.FilterComparison._getIntent1532)) as android.content.Intent;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._getIntent1532)) as android.content.Intent;
			}
			internal static global::MonoJavaBridge.MethodId _FilterComparison1533;
			public FilterComparison(android.content.Intent arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.FilterComparison.staticClass, global::android.content.Intent.FilterComparison._FilterComparison1533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.FilterComparison.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$FilterComparison"));
				global::android.content.Intent.FilterComparison._equals1530 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.content.Intent.FilterComparison._hashCode1531 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "hashCode", "()I");
				global::android.content.Intent.FilterComparison._getIntent1532 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "getIntent", "()Landroid/content/Intent;");
				global::android.content.Intent.FilterComparison._FilterComparison1533 = @__env.GetMethodIDNoThrow(global::android.content.Intent.FilterComparison.staticClass, "<init>", "(Landroid/content/Intent;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ShortcutIconResource : java.lang.Object, android.os.Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ShortcutIconResource()
			{
				InitJNI();
			}
			protected ShortcutIconResource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString1534;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource._toString1534)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._toString1534)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel1535;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource._writeToParcel1535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._writeToParcel1535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents1536;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource._describeContents1536);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._describeContents1536);
			}
			internal static global::MonoJavaBridge.MethodId _fromContext1537;
			public static global::android.content.Intent.ShortcutIconResource fromContext(android.content.Context arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._fromContext1537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent.ShortcutIconResource;
			}
			internal static global::MonoJavaBridge.MethodId _ShortcutIconResource1538;
			public ShortcutIconResource()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.ShortcutIconResource.staticClass, global::android.content.Intent.ShortcutIconResource._ShortcutIconResource1538);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _packageName1539;
			public global::java.lang.String packageName
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _resourceName1540;
			public global::java.lang.String resourceName
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR1541;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.Intent.ShortcutIconResource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent$ShortcutIconResource"));
				global::android.content.Intent.ShortcutIconResource._toString1534 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "toString", "()Ljava/lang/String;");
				global::android.content.Intent.ShortcutIconResource._writeToParcel1535 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.content.Intent.ShortcutIconResource._describeContents1536 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "describeContents", "()I");
				global::android.content.Intent.ShortcutIconResource._fromContext1537 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;");
				global::android.content.Intent.ShortcutIconResource._ShortcutIconResource1538 = @__env.GetMethodIDNoThrow(global::android.content.Intent.ShortcutIconResource.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString1542;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._toString1542)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._toString1542)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone1543;
		public virtual new global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._clone1543)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._clone1543)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getPackage1544;
		public virtual global::java.lang.String getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getPackage1544)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getPackage1544)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType1545;
		public virtual global::java.lang.String getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getType1545)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getType1545)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI1546;
		public virtual global::java.lang.String toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._toURI1546)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._toURI1546)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme1547;
		public virtual global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getScheme1547)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getScheme1547)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getData1548;
		public virtual global::android.net.Uri getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getData1548)) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getData1548)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getComponent1549;
		public virtual global::android.content.ComponentName getComponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getComponent1549)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getComponent1549)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _setClassName1550;
		public virtual global::android.content.Intent setClassName(android.content.Context arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setClassName1550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setClassName1550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setClassName1551;
		public virtual global::android.content.Intent setClassName(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setClassName1551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setClassName1551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1552;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._writeToParcel1552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._writeToParcel1552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1553;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._describeContents1553);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._describeContents1553);
		}
		internal static global::MonoJavaBridge.MethodId _createChooser1554;
		public static global::android.content.Intent createChooser(android.content.Intent arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._createChooser1554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _cloneFilter1555;
		public virtual global::android.content.Intent cloneFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._cloneFilter1555)) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._cloneFilter1555)) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getIntent1556;
		public static global::android.content.Intent getIntent(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._getIntent1556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _parseUri1557;
		public static global::android.content.Intent parseUri(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._parseUri1557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getIntentOld1558;
		public static global::android.content.Intent getIntentOld(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._getIntentOld1558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _getAction1559;
		public virtual global::java.lang.String getAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getAction1559)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getAction1559)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDataString1560;
		public virtual global::java.lang.String getDataString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getDataString1560)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getDataString1560)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveType1561;
		public virtual global::java.lang.String resolveType(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveType1561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveType1561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveType1562;
		public virtual global::java.lang.String resolveType(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveType1562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveType1562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _resolveTypeIfNeeded1563;
		public virtual global::java.lang.String resolveTypeIfNeeded(android.content.ContentResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveTypeIfNeeded1563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveTypeIfNeeded1563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasCategory1564;
		public virtual bool hasCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._hasCategory1564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._hasCategory1564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCategories1565;
		public virtual global::java.util.Set getCategories() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCategories1565)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCategories1565)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setExtrasClassLoader1566;
		public virtual void setExtrasClassLoader(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._setExtrasClassLoader1566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setExtrasClassLoader1566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasExtra1567;
		public virtual bool hasExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._hasExtra1567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._hasExtra1567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors1568;
		public virtual bool hasFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._hasFileDescriptors1568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._hasFileDescriptors1568);
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanExtra1569;
		public virtual bool getBooleanExtra(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._getBooleanExtra1569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getBooleanExtra1569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByteExtra1570;
		public virtual byte getByteExtra(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.content.Intent._getByteExtra1570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getByteExtra1570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShortExtra1571;
		public virtual short getShortExtra(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.content.Intent._getShortExtra1571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getShortExtra1571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCharExtra1572;
		public virtual char getCharExtra(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.content.Intent._getCharExtra1572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharExtra1572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIntExtra1573;
		public virtual int getIntExtra(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._getIntExtra1573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getIntExtra1573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLongExtra1574;
		public virtual long getLongExtra(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.Intent._getLongExtra1574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getLongExtra1574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloatExtra1575;
		public virtual float getFloatExtra(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.Intent._getFloatExtra1575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getFloatExtra1575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleExtra1576;
		public virtual double getDoubleExtra(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.content.Intent._getDoubleExtra1576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getDoubleExtra1576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getStringExtra1577;
		public virtual global::java.lang.String getStringExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getStringExtra1577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getStringExtra1577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceExtra1578;
		public virtual global::java.lang.CharSequence getCharSequenceExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharSequenceExtra1578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharSequenceExtra1578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableExtra1579;
		public virtual global::android.os.Parcelable getParcelableExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getParcelableExtra1579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getParcelableExtra1579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayExtra1580;
		public virtual global::android.os.Parcelable[] getParcelableArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getParcelableArrayExtra1580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getParcelableArrayExtra1580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayListExtra1581;
		public virtual global::java.util.ArrayList getParcelableArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getParcelableArrayListExtra1581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getParcelableArrayListExtra1581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getSerializableExtra1582;
		public virtual global::java.io.Serializable getSerializableExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getSerializableExtra1582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getSerializableExtra1582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerArrayListExtra1583;
		public virtual global::java.util.ArrayList getIntegerArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getIntegerArrayListExtra1583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getIntegerArrayListExtra1583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayListExtra1584;
		public virtual global::java.util.ArrayList getStringArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getStringArrayListExtra1584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getStringArrayListExtra1584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayListExtra1585;
		public virtual global::java.util.ArrayList getCharSequenceArrayListExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharSequenceArrayListExtra1585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharSequenceArrayListExtra1585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanArrayExtra1586;
		public virtual bool[] getBooleanArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getBooleanArrayExtra1586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getBooleanArrayExtra1586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getByteArrayExtra1587;
		public virtual byte[] getByteArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getByteArrayExtra1587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getByteArrayExtra1587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getShortArrayExtra1588;
		public virtual short[] getShortArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getShortArrayExtra1588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getShortArrayExtra1588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharArrayExtra1589;
		public virtual char[] getCharArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharArrayExtra1589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharArrayExtra1589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArrayExtra1590;
		public virtual int[] getIntArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getIntArrayExtra1590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getIntArrayExtra1590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getLongArrayExtra1591;
		public virtual long[] getLongArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getLongArrayExtra1591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getLongArrayExtra1591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _getFloatArrayExtra1592;
		public virtual float[] getFloatArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getFloatArrayExtra1592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getFloatArrayExtra1592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleArrayExtra1593;
		public virtual double[] getDoubleArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getDoubleArrayExtra1593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getDoubleArrayExtra1593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayExtra1594;
		public virtual global::java.lang.String[] getStringArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getStringArrayExtra1594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getStringArrayExtra1594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayExtra1595;
		public virtual global::java.lang.CharSequence[] getCharSequenceArrayExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getCharSequenceArrayExtra1595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getCharSequenceArrayExtra1595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getBundleExtra1596;
		public virtual global::android.os.Bundle getBundleExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getBundleExtra1596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getBundleExtra1596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getExtras1597;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getExtras1597)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getExtras1597)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getFlags1598;
		public virtual int getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._getFlags1598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getFlags1598);
		}
		internal static global::MonoJavaBridge.MethodId _getSourceBounds1599;
		public virtual global::android.graphics.Rect getSourceBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._getSourceBounds1599)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._getSourceBounds1599)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivity1600;
		public virtual global::android.content.ComponentName resolveActivity(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveActivity1600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveActivity1600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _resolveActivityInfo1601;
		public virtual global::android.content.pm.ActivityInfo resolveActivityInfo(android.content.pm.PackageManager arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._resolveActivityInfo1601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._resolveActivityInfo1601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _setAction1602;
		public virtual global::android.content.Intent setAction(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setAction1602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setAction1602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setData1603;
		public virtual global::android.content.Intent setData(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setData1603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setData1603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setType1604;
		public virtual global::android.content.Intent setType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setType1604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setType1604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setDataAndType1605;
		public virtual global::android.content.Intent setDataAndType(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setDataAndType1605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setDataAndType1605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _addCategory1606;
		public virtual global::android.content.Intent addCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._addCategory1606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._addCategory1606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _removeCategory1607;
		public virtual void removeCategory(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._removeCategory1607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._removeCategory1607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1608;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1609;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1610;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1611;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1612;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1613;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1614;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1615;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1616;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1617;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1618;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		public android.content.Intent putExtra(java.lang.String arg0, string arg1)
		{
			return putExtra(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1619;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1620;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1621;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.io.Serializable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1622;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1623;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, short[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1624;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1625;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1626;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, long[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1627;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1628;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1629;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1630;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtra1631;
		public virtual global::android.content.Intent putExtra(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtra1631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtra1631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArrayListExtra1632;
		public virtual global::android.content.Intent putParcelableArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putParcelableArrayListExtra1632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putParcelableArrayListExtra1632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putIntegerArrayListExtra1633;
		public virtual global::android.content.Intent putIntegerArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putIntegerArrayListExtra1633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putIntegerArrayListExtra1633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putStringArrayListExtra1634;
		public virtual global::android.content.Intent putStringArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putStringArrayListExtra1634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putStringArrayListExtra1634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArrayListExtra1635;
		public virtual global::android.content.Intent putCharSequenceArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putCharSequenceArrayListExtra1635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putCharSequenceArrayListExtra1635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtras1636;
		public virtual global::android.content.Intent putExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtras1636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtras1636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _putExtras1637;
		public virtual global::android.content.Intent putExtras(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._putExtras1637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._putExtras1637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _replaceExtras1638;
		public virtual global::android.content.Intent replaceExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._replaceExtras1638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._replaceExtras1638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _replaceExtras1639;
		public virtual global::android.content.Intent replaceExtras(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._replaceExtras1639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._replaceExtras1639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _removeExtra1640;
		public virtual void removeExtra(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._removeExtra1640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._removeExtra1640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags1641;
		public virtual global::android.content.Intent setFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setFlags1641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setFlags1641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _addFlags1642;
		public virtual global::android.content.Intent addFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._addFlags1642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._addFlags1642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setPackage1643;
		public virtual global::android.content.Intent setPackage(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setPackage1643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setPackage1643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setComponent1644;
		public virtual global::android.content.Intent setComponent(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setComponent1644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setComponent1644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setClass1645;
		public virtual global::android.content.Intent setClass(android.content.Context arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._setClass1645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setClass1645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _setSourceBounds1646;
		public virtual void setSourceBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._setSourceBounds1646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._setSourceBounds1646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fillIn1647;
		public virtual int fillIn(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._fillIn1647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._fillIn1647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _filterEquals1648;
		public virtual bool filterEquals(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.Intent._filterEquals1648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._filterEquals1648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _filterHashCode1649;
		public virtual int filterHashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.Intent._filterHashCode1649);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._filterHashCode1649);
		}
		internal static global::MonoJavaBridge.MethodId _toUri1650;
		public virtual global::java.lang.String toUri(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.Intent._toUri1650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._toUri1650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel1651;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.Intent._readFromParcel1651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.Intent.staticClass, global::android.content.Intent._readFromParcel1651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseIntent1652;
		public static global::android.content.Intent parseIntent(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.Intent.staticClass, global::android.content.Intent._parseIntent1652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.content.Intent;
		}
		internal static global::MonoJavaBridge.MethodId _Intent1653;
		public Intent()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent1653);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent1654;
		public Intent(android.content.Intent arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent1654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent1655;
		public Intent(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent1655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent1656;
		public Intent(java.lang.String arg0, android.net.Uri arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent1656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent1657;
		public Intent(android.content.Context arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent1657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Intent1658;
		public Intent(java.lang.String arg0, android.net.Uri arg1, android.content.Context arg2, java.lang.Class arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.Intent.staticClass, global::android.content.Intent._Intent1658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		public static global::java.lang.String ACTION_MAIN
		{
			get
			{
				return "android.intent.action.MAIN";
			}
		}
		public static global::java.lang.String ACTION_VIEW
		{
			get
			{
				return "android.intent.action.VIEW";
			}
		}
		public static global::java.lang.String ACTION_DEFAULT
		{
			get
			{
				return "android.intent.action.VIEW";
			}
		}
		public static global::java.lang.String ACTION_ATTACH_DATA
		{
			get
			{
				return "android.intent.action.ATTACH_DATA";
			}
		}
		public static global::java.lang.String ACTION_EDIT
		{
			get
			{
				return "android.intent.action.EDIT";
			}
		}
		public static global::java.lang.String ACTION_INSERT_OR_EDIT
		{
			get
			{
				return "android.intent.action.INSERT_OR_EDIT";
			}
		}
		public static global::java.lang.String ACTION_PICK
		{
			get
			{
				return "android.intent.action.PICK";
			}
		}
		public static global::java.lang.String ACTION_CREATE_SHORTCUT
		{
			get
			{
				return "android.intent.action.CREATE_SHORTCUT";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_INTENT
		{
			get
			{
				return "android.intent.extra.shortcut.INTENT";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_NAME
		{
			get
			{
				return "android.intent.extra.shortcut.NAME";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_ICON
		{
			get
			{
				return "android.intent.extra.shortcut.ICON";
			}
		}
		public static global::java.lang.String EXTRA_SHORTCUT_ICON_RESOURCE
		{
			get
			{
				return "android.intent.extra.shortcut.ICON_RESOURCE";
			}
		}
		public static global::java.lang.String ACTION_CHOOSER
		{
			get
			{
				return "android.intent.action.CHOOSER";
			}
		}
		public static global::java.lang.String ACTION_GET_CONTENT
		{
			get
			{
				return "android.intent.action.GET_CONTENT";
			}
		}
		public static global::java.lang.String ACTION_DIAL
		{
			get
			{
				return "android.intent.action.DIAL";
			}
		}
		public static global::java.lang.String ACTION_CALL
		{
			get
			{
				return "android.intent.action.CALL";
			}
		}
		public static global::java.lang.String ACTION_SENDTO
		{
			get
			{
				return "android.intent.action.SENDTO";
			}
		}
		public static global::java.lang.String ACTION_SEND
		{
			get
			{
				return "android.intent.action.SEND";
			}
		}
		public static global::java.lang.String ACTION_SEND_MULTIPLE
		{
			get
			{
				return "android.intent.action.SEND_MULTIPLE";
			}
		}
		public static global::java.lang.String ACTION_ANSWER
		{
			get
			{
				return "android.intent.action.ANSWER";
			}
		}
		public static global::java.lang.String ACTION_INSERT
		{
			get
			{
				return "android.intent.action.INSERT";
			}
		}
		public static global::java.lang.String ACTION_DELETE
		{
			get
			{
				return "android.intent.action.DELETE";
			}
		}
		public static global::java.lang.String ACTION_RUN
		{
			get
			{
				return "android.intent.action.RUN";
			}
		}
		public static global::java.lang.String ACTION_SYNC
		{
			get
			{
				return "android.intent.action.SYNC";
			}
		}
		public static global::java.lang.String ACTION_PICK_ACTIVITY
		{
			get
			{
				return "android.intent.action.PICK_ACTIVITY";
			}
		}
		public static global::java.lang.String ACTION_SEARCH
		{
			get
			{
				return "android.intent.action.SEARCH";
			}
		}
		public static global::java.lang.String ACTION_SYSTEM_TUTORIAL
		{
			get
			{
				return "android.intent.action.SYSTEM_TUTORIAL";
			}
		}
		public static global::java.lang.String ACTION_WEB_SEARCH
		{
			get
			{
				return "android.intent.action.WEB_SEARCH";
			}
		}
		public static global::java.lang.String ACTION_ALL_APPS
		{
			get
			{
				return "android.intent.action.ALL_APPS";
			}
		}
		public static global::java.lang.String ACTION_SET_WALLPAPER
		{
			get
			{
				return "android.intent.action.SET_WALLPAPER";
			}
		}
		public static global::java.lang.String ACTION_BUG_REPORT
		{
			get
			{
				return "android.intent.action.BUG_REPORT";
			}
		}
		public static global::java.lang.String ACTION_FACTORY_TEST
		{
			get
			{
				return "android.intent.action.FACTORY_TEST";
			}
		}
		public static global::java.lang.String ACTION_CALL_BUTTON
		{
			get
			{
				return "android.intent.action.CALL_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_VOICE_COMMAND
		{
			get
			{
				return "android.intent.action.VOICE_COMMAND";
			}
		}
		public static global::java.lang.String ACTION_SEARCH_LONG_PRESS
		{
			get
			{
				return "android.intent.action.SEARCH_LONG_PRESS";
			}
		}
		public static global::java.lang.String ACTION_POWER_USAGE_SUMMARY
		{
			get
			{
				return "android.intent.action.POWER_USAGE_SUMMARY";
			}
		}
		public static global::java.lang.String ACTION_SCREEN_OFF
		{
			get
			{
				return "android.intent.action.SCREEN_OFF";
			}
		}
		public static global::java.lang.String ACTION_SCREEN_ON
		{
			get
			{
				return "android.intent.action.SCREEN_ON";
			}
		}
		public static global::java.lang.String ACTION_USER_PRESENT
		{
			get
			{
				return "android.intent.action.USER_PRESENT";
			}
		}
		public static global::java.lang.String ACTION_TIME_TICK
		{
			get
			{
				return "android.intent.action.TIME_TICK";
			}
		}
		public static global::java.lang.String ACTION_TIME_CHANGED
		{
			get
			{
				return "android.intent.action.TIME_SET";
			}
		}
		public static global::java.lang.String ACTION_DATE_CHANGED
		{
			get
			{
				return "android.intent.action.DATE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_TIMEZONE_CHANGED
		{
			get
			{
				return "android.intent.action.TIMEZONE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BOOT_COMPLETED
		{
			get
			{
				return "android.intent.action.BOOT_COMPLETED";
			}
		}
		public static global::java.lang.String ACTION_CLOSE_SYSTEM_DIALOGS
		{
			get
			{
				return "android.intent.action.CLOSE_SYSTEM_DIALOGS";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_INSTALL
		{
			get
			{
				return "android.intent.action.PACKAGE_INSTALL";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_ADDED
		{
			get
			{
				return "android.intent.action.PACKAGE_ADDED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_REPLACED
		{
			get
			{
				return "android.intent.action.PACKAGE_REPLACED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_REMOVED
		{
			get
			{
				return "android.intent.action.PACKAGE_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_CHANGED
		{
			get
			{
				return "android.intent.action.PACKAGE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_RESTARTED
		{
			get
			{
				return "android.intent.action.PACKAGE_RESTARTED";
			}
		}
		public static global::java.lang.String ACTION_PACKAGE_DATA_CLEARED
		{
			get
			{
				return "android.intent.action.PACKAGE_DATA_CLEARED";
			}
		}
		public static global::java.lang.String ACTION_UID_REMOVED
		{
			get
			{
				return "android.intent.action.UID_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_EXTERNAL_APPLICATIONS_AVAILABLE
		{
			get
			{
				return "android.intent.action.EXTERNAL_APPLICATIONS_AVAILABLE";
			}
		}
		public static global::java.lang.String ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE
		{
			get
			{
				return "android.intent.action.EXTERNAL_APPLICATIONS_UNAVAILABLE";
			}
		}
		public static global::java.lang.String ACTION_WALLPAPER_CHANGED
		{
			get
			{
				return "android.intent.action.WALLPAPER_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_CONFIGURATION_CHANGED
		{
			get
			{
				return "android.intent.action.CONFIGURATION_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_LOCALE_CHANGED
		{
			get
			{
				return "android.intent.action.LOCALE_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_CHANGED
		{
			get
			{
				return "android.intent.action.BATTERY_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_LOW
		{
			get
			{
				return "android.intent.action.BATTERY_LOW";
			}
		}
		public static global::java.lang.String ACTION_BATTERY_OKAY
		{
			get
			{
				return "android.intent.action.BATTERY_OKAY";
			}
		}
		public static global::java.lang.String ACTION_POWER_CONNECTED
		{
			get
			{
				return "android.intent.action.ACTION_POWER_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_POWER_DISCONNECTED
		{
			get
			{
				return "android.intent.action.ACTION_POWER_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_SHUTDOWN
		{
			get
			{
				return "android.intent.action.ACTION_SHUTDOWN";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_STORAGE_LOW
		{
			get
			{
				return "android.intent.action.DEVICE_STORAGE_LOW";
			}
		}
		public static global::java.lang.String ACTION_DEVICE_STORAGE_OK
		{
			get
			{
				return "android.intent.action.DEVICE_STORAGE_OK";
			}
		}
		public static global::java.lang.String ACTION_MANAGE_PACKAGE_STORAGE
		{
			get
			{
				return "android.intent.action.MANAGE_PACKAGE_STORAGE";
			}
		}
		public static global::java.lang.String ACTION_UMS_CONNECTED
		{
			get
			{
				return "android.intent.action.UMS_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_UMS_DISCONNECTED
		{
			get
			{
				return "android.intent.action.UMS_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_REMOVED
		{
			get
			{
				return "android.intent.action.MEDIA_REMOVED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_UNMOUNTED
		{
			get
			{
				return "android.intent.action.MEDIA_UNMOUNTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_CHECKING
		{
			get
			{
				return "android.intent.action.MEDIA_CHECKING";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_NOFS
		{
			get
			{
				return "android.intent.action.MEDIA_NOFS";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_MOUNTED
		{
			get
			{
				return "android.intent.action.MEDIA_MOUNTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SHARED
		{
			get
			{
				return "android.intent.action.MEDIA_SHARED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_BAD_REMOVAL
		{
			get
			{
				return "android.intent.action.MEDIA_BAD_REMOVAL";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_UNMOUNTABLE
		{
			get
			{
				return "android.intent.action.MEDIA_UNMOUNTABLE";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_EJECT
		{
			get
			{
				return "android.intent.action.MEDIA_EJECT";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_STARTED
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_STARTED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_FINISHED
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_FINISHED";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_SCANNER_SCAN_FILE
		{
			get
			{
				return "android.intent.action.MEDIA_SCANNER_SCAN_FILE";
			}
		}
		public static global::java.lang.String ACTION_MEDIA_BUTTON
		{
			get
			{
				return "android.intent.action.MEDIA_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_CAMERA_BUTTON
		{
			get
			{
				return "android.intent.action.CAMERA_BUTTON";
			}
		}
		public static global::java.lang.String ACTION_GTALK_SERVICE_CONNECTED
		{
			get
			{
				return "android.intent.action.GTALK_CONNECTED";
			}
		}
		public static global::java.lang.String ACTION_GTALK_SERVICE_DISCONNECTED
		{
			get
			{
				return "android.intent.action.GTALK_DISCONNECTED";
			}
		}
		public static global::java.lang.String ACTION_INPUT_METHOD_CHANGED
		{
			get
			{
				return "android.intent.action.INPUT_METHOD_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_AIRPLANE_MODE_CHANGED
		{
			get
			{
				return "android.intent.action.AIRPLANE_MODE";
			}
		}
		public static global::java.lang.String ACTION_PROVIDER_CHANGED
		{
			get
			{
				return "android.intent.action.PROVIDER_CHANGED";
			}
		}
		public static global::java.lang.String ACTION_HEADSET_PLUG
		{
			get
			{
				return "android.intent.action.HEADSET_PLUG";
			}
		}
		public static global::java.lang.String ACTION_NEW_OUTGOING_CALL
		{
			get
			{
				return "android.intent.action.NEW_OUTGOING_CALL";
			}
		}
		public static global::java.lang.String ACTION_REBOOT
		{
			get
			{
				return "android.intent.action.REBOOT";
			}
		}
		public static global::java.lang.String ACTION_DOCK_EVENT
		{
			get
			{
				return "android.intent.action.DOCK_EVENT";
			}
		}
		public static global::java.lang.String CATEGORY_DEFAULT
		{
			get
			{
				return "android.intent.category.DEFAULT";
			}
		}
		public static global::java.lang.String CATEGORY_BROWSABLE
		{
			get
			{
				return "android.intent.category.BROWSABLE";
			}
		}
		public static global::java.lang.String CATEGORY_ALTERNATIVE
		{
			get
			{
				return "android.intent.category.ALTERNATIVE";
			}
		}
		public static global::java.lang.String CATEGORY_SELECTED_ALTERNATIVE
		{
			get
			{
				return "android.intent.category.SELECTED_ALTERNATIVE";
			}
		}
		public static global::java.lang.String CATEGORY_TAB
		{
			get
			{
				return "android.intent.category.TAB";
			}
		}
		public static global::java.lang.String CATEGORY_LAUNCHER
		{
			get
			{
				return "android.intent.category.LAUNCHER";
			}
		}
		public static global::java.lang.String CATEGORY_INFO
		{
			get
			{
				return "android.intent.category.INFO";
			}
		}
		public static global::java.lang.String CATEGORY_HOME
		{
			get
			{
				return "android.intent.category.HOME";
			}
		}
		public static global::java.lang.String CATEGORY_PREFERENCE
		{
			get
			{
				return "android.intent.category.PREFERENCE";
			}
		}
		public static global::java.lang.String CATEGORY_DEVELOPMENT_PREFERENCE
		{
			get
			{
				return "android.intent.category.DEVELOPMENT_PREFERENCE";
			}
		}
		public static global::java.lang.String CATEGORY_EMBED
		{
			get
			{
				return "android.intent.category.EMBED";
			}
		}
		public static global::java.lang.String CATEGORY_MONKEY
		{
			get
			{
				return "android.intent.category.MONKEY";
			}
		}
		public static global::java.lang.String CATEGORY_TEST
		{
			get
			{
				return "android.intent.category.TEST";
			}
		}
		public static global::java.lang.String CATEGORY_UNIT_TEST
		{
			get
			{
				return "android.intent.category.UNIT_TEST";
			}
		}
		public static global::java.lang.String CATEGORY_SAMPLE_CODE
		{
			get
			{
				return "android.intent.category.SAMPLE_CODE";
			}
		}
		public static global::java.lang.String CATEGORY_OPENABLE
		{
			get
			{
				return "android.intent.category.OPENABLE";
			}
		}
		public static global::java.lang.String CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST
		{
			get
			{
				return "android.intent.category.FRAMEWORK_INSTRUMENTATION_TEST";
			}
		}
		public static global::java.lang.String CATEGORY_CAR_DOCK
		{
			get
			{
				return "android.intent.category.CAR_DOCK";
			}
		}
		public static global::java.lang.String CATEGORY_DESK_DOCK
		{
			get
			{
				return "android.intent.category.DESK_DOCK";
			}
		}
		public static global::java.lang.String CATEGORY_CAR_MODE
		{
			get
			{
				return "android.intent.category.CAR_MODE";
			}
		}
		public static global::java.lang.String EXTRA_TEMPLATE
		{
			get
			{
				return "android.intent.extra.TEMPLATE";
			}
		}
		public static global::java.lang.String EXTRA_TEXT
		{
			get
			{
				return "android.intent.extra.TEXT";
			}
		}
		public static global::java.lang.String EXTRA_STREAM
		{
			get
			{
				return "android.intent.extra.STREAM";
			}
		}
		public static global::java.lang.String EXTRA_EMAIL
		{
			get
			{
				return "android.intent.extra.EMAIL";
			}
		}
		public static global::java.lang.String EXTRA_CC
		{
			get
			{
				return "android.intent.extra.CC";
			}
		}
		public static global::java.lang.String EXTRA_BCC
		{
			get
			{
				return "android.intent.extra.BCC";
			}
		}
		public static global::java.lang.String EXTRA_SUBJECT
		{
			get
			{
				return "android.intent.extra.SUBJECT";
			}
		}
		public static global::java.lang.String EXTRA_INTENT
		{
			get
			{
				return "android.intent.extra.INTENT";
			}
		}
		public static global::java.lang.String EXTRA_TITLE
		{
			get
			{
				return "android.intent.extra.TITLE";
			}
		}
		public static global::java.lang.String EXTRA_INITIAL_INTENTS
		{
			get
			{
				return "android.intent.extra.INITIAL_INTENTS";
			}
		}
		public static global::java.lang.String EXTRA_KEY_EVENT
		{
			get
			{
				return "android.intent.extra.KEY_EVENT";
			}
		}
		public static global::java.lang.String EXTRA_DONT_KILL_APP
		{
			get
			{
				return "android.intent.extra.DONT_KILL_APP";
			}
		}
		public static global::java.lang.String EXTRA_PHONE_NUMBER
		{
			get
			{
				return "android.intent.extra.PHONE_NUMBER";
			}
		}
		public static global::java.lang.String EXTRA_UID
		{
			get
			{
				return "android.intent.extra.UID";
			}
		}
		public static global::java.lang.String EXTRA_DATA_REMOVED
		{
			get
			{
				return "android.intent.extra.DATA_REMOVED";
			}
		}
		public static global::java.lang.String EXTRA_REPLACING
		{
			get
			{
				return "android.intent.extra.REPLACING";
			}
		}
		public static global::java.lang.String EXTRA_ALARM_COUNT
		{
			get
			{
				return "android.intent.extra.ALARM_COUNT";
			}
		}
		public static global::java.lang.String EXTRA_DOCK_STATE
		{
			get
			{
				return "android.intent.extra.DOCK_STATE";
			}
		}
		public static int EXTRA_DOCK_STATE_UNDOCKED
		{
			get
			{
				return 0;
			}
		}
		public static int EXTRA_DOCK_STATE_DESK
		{
			get
			{
				return 1;
			}
		}
		public static int EXTRA_DOCK_STATE_CAR
		{
			get
			{
				return 2;
			}
		}
		public static global::java.lang.String METADATA_DOCK_HOME
		{
			get
			{
				return "android.dock_home";
			}
		}
		public static global::java.lang.String EXTRA_REMOTE_INTENT_TOKEN
		{
			get
			{
				return "android.intent.extra.remote_intent_token";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_COMPONENT_NAME
		{
			get
			{
				return "android.intent.extra.changed_component_name";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_COMPONENT_NAME_LIST
		{
			get
			{
				return "android.intent.extra.changed_component_name_list";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_PACKAGE_LIST
		{
			get
			{
				return "android.intent.extra.changed_package_list";
			}
		}
		public static global::java.lang.String EXTRA_CHANGED_UID_LIST
		{
			get
			{
				return "android.intent.extra.changed_uid_list";
			}
		}
		public static int FLAG_GRANT_READ_URI_PERMISSION
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_GRANT_WRITE_URI_PERMISSION
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_FROM_BACKGROUND
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_DEBUG_LOG_RESOLUTION
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_ACTIVITY_NO_HISTORY
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_ACTIVITY_SINGLE_TOP
		{
			get
			{
				return 536870912;
			}
		}
		public static int FLAG_ACTIVITY_NEW_TASK
		{
			get
			{
				return 268435456;
			}
		}
		public static int FLAG_ACTIVITY_MULTIPLE_TASK
		{
			get
			{
				return 134217728;
			}
		}
		public static int FLAG_ACTIVITY_CLEAR_TOP
		{
			get
			{
				return 67108864;
			}
		}
		public static int FLAG_ACTIVITY_FORWARD_RESULT
		{
			get
			{
				return 33554432;
			}
		}
		public static int FLAG_ACTIVITY_PREVIOUS_IS_TOP
		{
			get
			{
				return 16777216;
			}
		}
		public static int FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS
		{
			get
			{
				return 8388608;
			}
		}
		public static int FLAG_ACTIVITY_BROUGHT_TO_FRONT
		{
			get
			{
				return 4194304;
			}
		}
		public static int FLAG_ACTIVITY_RESET_TASK_IF_NEEDED
		{
			get
			{
				return 2097152;
			}
		}
		public static int FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY
		{
			get
			{
				return 1048576;
			}
		}
		public static int FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET
		{
			get
			{
				return 524288;
			}
		}
		public static int FLAG_ACTIVITY_NO_USER_ACTION
		{
			get
			{
				return 262144;
			}
		}
		public static int FLAG_ACTIVITY_REORDER_TO_FRONT
		{
			get
			{
				return 131072;
			}
		}
		public static int FLAG_ACTIVITY_NO_ANIMATION
		{
			get
			{
				return 65536;
			}
		}
		public static int FLAG_RECEIVER_REGISTERED_ONLY
		{
			get
			{
				return 1073741824;
			}
		}
		public static int FLAG_RECEIVER_REPLACE_PENDING
		{
			get
			{
				return 536870912;
			}
		}
		public static int URI_INTENT_SCHEME
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_IN_ACTION
		{
			get
			{
				return 1;
			}
		}
		public static int FILL_IN_DATA
		{
			get
			{
				return 2;
			}
		}
		public static int FILL_IN_CATEGORIES
		{
			get
			{
				return 4;
			}
		}
		public static int FILL_IN_COMPONENT
		{
			get
			{
				return 8;
			}
		}
		public static int FILL_IN_PACKAGE
		{
			get
			{
				return 16;
			}
		}
		public static int FILL_IN_SOURCE_BOUNDS
		{
			get
			{
				return 32;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1659;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.Intent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/Intent"));
			global::android.content.Intent._toString1542 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.Intent._clone1543 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.content.Intent._getPackage1544 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getPackage", "()Ljava/lang/String;");
			global::android.content.Intent._getType1545 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getType", "()Ljava/lang/String;");
			global::android.content.Intent._toURI1546 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "toURI", "()Ljava/lang/String;");
			global::android.content.Intent._getScheme1547 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getScheme", "()Ljava/lang/String;");
			global::android.content.Intent._getData1548 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getData", "()Landroid/net/Uri;");
			global::android.content.Intent._getComponent1549 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.content.Intent._setClassName1550 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setClassName", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setClassName1551 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setClassName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._writeToParcel1552 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.Intent._describeContents1553 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "describeContents", "()I");
			global::android.content.Intent._createChooser1554 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;");
			global::android.content.Intent._cloneFilter1555 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "cloneFilter", "()Landroid/content/Intent;");
			global::android.content.Intent._getIntent1556 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._parseUri1557 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;");
			global::android.content.Intent._getIntentOld1558 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._getAction1559 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getAction", "()Ljava/lang/String;");
			global::android.content.Intent._getDataString1560 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getDataString", "()Ljava/lang/String;");
			global::android.content.Intent._resolveType1561 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.content.Intent._resolveType1562 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			global::android.content.Intent._resolveTypeIfNeeded1563 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			global::android.content.Intent._hasCategory1564 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "hasCategory", "(Ljava/lang/String;)Z");
			global::android.content.Intent._getCategories1565 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCategories", "()Ljava/util/Set;");
			global::android.content.Intent._setExtrasClassLoader1566 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::android.content.Intent._hasExtra1567 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "hasExtra", "(Ljava/lang/String;)Z");
			global::android.content.Intent._hasFileDescriptors1568 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "hasFileDescriptors", "()Z");
			global::android.content.Intent._getBooleanExtra1569 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getBooleanExtra", "(Ljava/lang/String;Z)Z");
			global::android.content.Intent._getByteExtra1570 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getByteExtra", "(Ljava/lang/String;B)B");
			global::android.content.Intent._getShortExtra1571 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getShortExtra", "(Ljava/lang/String;S)S");
			global::android.content.Intent._getCharExtra1572 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharExtra", "(Ljava/lang/String;C)C");
			global::android.content.Intent._getIntExtra1573 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntExtra", "(Ljava/lang/String;I)I");
			global::android.content.Intent._getLongExtra1574 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getLongExtra", "(Ljava/lang/String;J)J");
			global::android.content.Intent._getFloatExtra1575 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getFloatExtra", "(Ljava/lang/String;F)F");
			global::android.content.Intent._getDoubleExtra1576 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getDoubleExtra", "(Ljava/lang/String;D)D");
			global::android.content.Intent._getStringExtra1577 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.Intent._getCharSequenceExtra1578 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.content.Intent._getParcelableExtra1579 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			global::android.content.Intent._getParcelableArrayExtra1580 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;");
			global::android.content.Intent._getParcelableArrayListExtra1581 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getSerializableExtra1582 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;");
			global::android.content.Intent._getIntegerArrayListExtra1583 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getStringArrayListExtra1584 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getCharSequenceArrayListExtra1585 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharSequenceArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.content.Intent._getBooleanArrayExtra1586 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getBooleanArrayExtra", "(Ljava/lang/String;)[Z");
			global::android.content.Intent._getByteArrayExtra1587 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getByteArrayExtra", "(Ljava/lang/String;)[B");
			global::android.content.Intent._getShortArrayExtra1588 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getShortArrayExtra", "(Ljava/lang/String;)[S");
			global::android.content.Intent._getCharArrayExtra1589 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharArrayExtra", "(Ljava/lang/String;)[C");
			global::android.content.Intent._getIntArrayExtra1590 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getIntArrayExtra", "(Ljava/lang/String;)[I");
			global::android.content.Intent._getLongArrayExtra1591 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getLongArrayExtra", "(Ljava/lang/String;)[J");
			global::android.content.Intent._getFloatArrayExtra1592 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getFloatArrayExtra", "(Ljava/lang/String;)[F");
			global::android.content.Intent._getDoubleArrayExtra1593 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getDoubleArrayExtra", "(Ljava/lang/String;)[D");
			global::android.content.Intent._getStringArrayExtra1594 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.Intent._getCharSequenceArrayExtra1595 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getCharSequenceArrayExtra", "(Ljava/lang/String;)[Ljava/lang/CharSequence;");
			global::android.content.Intent._getBundleExtra1596 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.content.Intent._getExtras1597 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.content.Intent._getFlags1598 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getFlags", "()I");
			global::android.content.Intent._getSourceBounds1599 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "getSourceBounds", "()Landroid/graphics/Rect;");
			global::android.content.Intent._resolveActivity1600 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;");
			global::android.content.Intent._resolveActivityInfo1601 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;");
			global::android.content.Intent._setAction1602 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setAction", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setData1603 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setData", "(Landroid/net/Uri;)Landroid/content/Intent;");
			global::android.content.Intent._setType1604 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setType", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setDataAndType1605 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._addCategory1606 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "addCategory", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._removeCategory1607 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "removeCategory", "(Ljava/lang/String;)V");
			global::android.content.Intent._putExtra1608 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Z)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1609 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Z)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1610 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1611 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;C)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1612 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;S)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1613 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;I)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1614 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;J)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1615 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;F)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1616 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;D)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1617 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1618 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/CharSequence;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1619 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Parcelable;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1620 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1621 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1622 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1623 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[S)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1624 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[C)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1625 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[I)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1626 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[J)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1627 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[F)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1628 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[D)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1629 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1630 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/CharSequence;)Landroid/content/Intent;");
			global::android.content.Intent._putExtra1631 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;");
			global::android.content.Intent._putParcelableArrayListExtra1632 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putIntegerArrayListExtra1633 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putStringArrayListExtra1634 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putCharSequenceArrayListExtra1635 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putCharSequenceArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;");
			global::android.content.Intent._putExtras1636 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;");
			global::android.content.Intent._putExtras1637 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;");
			global::android.content.Intent._replaceExtras1638 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;");
			global::android.content.Intent._replaceExtras1639 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;");
			global::android.content.Intent._removeExtra1640 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "removeExtra", "(Ljava/lang/String;)V");
			global::android.content.Intent._setFlags1641 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setFlags", "(I)Landroid/content/Intent;");
			global::android.content.Intent._addFlags1642 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "addFlags", "(I)Landroid/content/Intent;");
			global::android.content.Intent._setPackage1643 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setPackage", "(Ljava/lang/String;)Landroid/content/Intent;");
			global::android.content.Intent._setComponent1644 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;");
			global::android.content.Intent._setClass1645 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;");
			global::android.content.Intent._setSourceBounds1646 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "setSourceBounds", "(Landroid/graphics/Rect;)V");
			global::android.content.Intent._fillIn1647 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "fillIn", "(Landroid/content/Intent;I)I");
			global::android.content.Intent._filterEquals1648 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "filterEquals", "(Landroid/content/Intent;)Z");
			global::android.content.Intent._filterHashCode1649 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "filterHashCode", "()I");
			global::android.content.Intent._toUri1650 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "toUri", "(I)Ljava/lang/String;");
			global::android.content.Intent._readFromParcel1651 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.Intent._parseIntent1652 = @__env.GetStaticMethodIDNoThrow(global::android.content.Intent.staticClass, "parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/content/Intent;");
			global::android.content.Intent._Intent1653 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "()V");
			global::android.content.Intent._Intent1654 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Intent;)V");
			global::android.content.Intent._Intent1655 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.Intent._Intent1656 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;)V");
			global::android.content.Intent._Intent1657 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::android.content.Intent._Intent1658 = @__env.GetMethodIDNoThrow(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V");
		}
	}
}

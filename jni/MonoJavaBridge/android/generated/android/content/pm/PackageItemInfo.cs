namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageItemInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PackageItemInfo()
		{
			InitJNI();
		}
		protected PackageItemInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DisplayNameComparator()
			{
				InitJNI();
			}
			protected DisplayNameComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _compare3758;
			public virtual int compare(android.content.pm.PackageItemInfo arg0, android.content.pm.PackageItemInfo arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare3759;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator3760;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator3760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageItemInfo$DisplayNameComparator"));
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3758 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I");
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3759 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator3760 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3761;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._writeToParcel3761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._writeToParcel3761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel3762;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._loadLabel3762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadLabel3762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon3763;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._loadIcon3763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadIcon3763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _loadXmlMetaData3764;
		public virtual global::android.content.res.XmlResourceParser loadXmlMetaData(android.content.pm.PackageManager arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._loadXmlMetaData3764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadXmlMetaData3764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _dumpFront3765;
		protected virtual void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._dumpFront3765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._dumpFront3765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dumpBack3766;
		protected virtual void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._dumpBack3766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._dumpBack3766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _PackageItemInfo3767;
		public PackageItemInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo3767);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageItemInfo3768;
		public PackageItemInfo(android.content.pm.PackageItemInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo3768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageItemInfo3769;
		protected PackageItemInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo3769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name3770;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name3770)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName3771;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3771)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes3772;
		public int labelRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelRes3772);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel3773;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedLabel3773)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon3774;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon3774);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _metaData3775;
		public global::android.os.Bundle metaData
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _metaData3775)) as android.os.Bundle;
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageItemInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageItemInfo"));
			global::android.content.pm.PackageItemInfo._writeToParcel3761 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageItemInfo._loadLabel3762 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageItemInfo._loadIcon3763 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageItemInfo._loadXmlMetaData3764 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageItemInfo._dumpFront3765 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.PackageItemInfo._dumpBack3766 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo3767 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo3768 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/content/pm/PackageItemInfo;)V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo3769 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.PackageItemInfo._name3770 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "name", "Ljava/lang/String;");
			global::android.content.pm.PackageItemInfo._packageName3771 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageItemInfo._labelRes3772 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "labelRes", "I");
			global::android.content.pm.PackageItemInfo._nonLocalizedLabel3773 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "nonLocalizedLabel", "Ljava/lang/CharSequence;");
			global::android.content.pm.PackageItemInfo._icon3774 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "icon", "I");
			global::android.content.pm.PackageItemInfo._metaData3775 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "metaData", "Landroid/os/Bundle;");
		}
	}
}

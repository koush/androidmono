namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageItemInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageItemInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DisplayNameComparator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _compare3775;
			public virtual int compare(android.content.pm.PackageItemInfo arg0, android.content.pm.PackageItemInfo arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _compare3776;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _DisplayNameComparator3777;
			public DisplayNameComparator(android.content.pm.PackageManager arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator3777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static DisplayNameComparator()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageItemInfo$DisplayNameComparator"));
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3775 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I");
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare3776 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator3777 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3778;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._writeToParcel3778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._writeToParcel3778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel3779;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._loadLabel3779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadLabel3779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon3780;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._loadIcon3780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadIcon3780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _loadXmlMetaData3781;
		public virtual global::android.content.res.XmlResourceParser loadXmlMetaData(android.content.pm.PackageManager arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._loadXmlMetaData3781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadXmlMetaData3781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _dumpFront3782;
		protected virtual void dumpFront(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._dumpFront3782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._dumpFront3782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpFront(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpFront((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _dumpBack3783;
		protected virtual void dumpBack(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo._dumpBack3783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._dumpBack3783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void dumpBack(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dumpBack((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _PackageItemInfo3784;
		public PackageItemInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo3784);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageItemInfo3785;
		public PackageItemInfo(android.content.pm.PackageItemInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo3785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageItemInfo3786;
		protected PackageItemInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo3786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name3787;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name3787)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName3788;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3788)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelRes3789;
		public int labelRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _labelRes3789);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedLabel3790;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedLabel3790)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon3791;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon3791);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _metaData3792;
		public global::android.os.Bundle metaData
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.GetObjectField(this.JvmHandle, _metaData3792)) as android.os.Bundle;
			}
			set
			{
			}
		}
		static PackageItemInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageItemInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageItemInfo"));
			global::android.content.pm.PackageItemInfo._writeToParcel3778 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageItemInfo._loadLabel3779 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageItemInfo._loadIcon3780 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageItemInfo._loadXmlMetaData3781 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageItemInfo._dumpFront3782 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.PackageItemInfo._dumpBack3783 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo3784 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo3785 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/content/pm/PackageItemInfo;)V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo3786 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.PackageItemInfo._name3787 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "name", "Ljava/lang/String;");
			global::android.content.pm.PackageItemInfo._packageName3788 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageItemInfo._labelRes3789 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "labelRes", "I");
			global::android.content.pm.PackageItemInfo._nonLocalizedLabel3790 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "nonLocalizedLabel", "Ljava/lang/CharSequence;");
			global::android.content.pm.PackageItemInfo._icon3791 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "icon", "I");
			global::android.content.pm.PackageItemInfo._metaData3792 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageItemInfo.staticClass, "metaData", "Landroid/os/Bundle;");
		}
		internal static void InitJNI()
		{
		}
	}
}

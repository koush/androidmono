namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PackageItemInfo : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PackageItemInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PackageItemInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.PackageItemInfo(@__env);
			}
		}
		protected PackageItemInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal static global::java.lang.Class staticClass;
			static DisplayNameComparator()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PackageItemInfo.DisplayNameComparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.pm.PackageItemInfo.DisplayNameComparator(@__env);
				}
			}
			protected DisplayNameComparator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _compare1868;
			public virtual int compare(android.content.pm.PackageItemInfo arg0, android.content.pm.PackageItemInfo arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _compare1869;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1869, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _DisplayNameComparator1870;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator1870, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass = @__class;
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1868 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I");
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1869 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator1870 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1871;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PackageItemInfo._writeToParcel1871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._writeToParcel1871, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1872;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PackageItemInfo._loadLabel1872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadLabel1872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon1873;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PackageItemInfo._loadIcon1873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadIcon1873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadXmlMetaData1874;
		public virtual global::android.content.res.XmlResourceParser loadXmlMetaData(android.content.pm.PackageManager arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PackageItemInfo._loadXmlMetaData1874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._loadXmlMetaData1874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpFront1875;
		protected virtual void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PackageItemInfo._dumpFront1875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._dumpFront1875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpBack1876;
		protected virtual void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PackageItemInfo._dumpBack1876, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._dumpBack1876, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageItemInfo1877;
		public PackageItemInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo1877, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageItemInfo1878;
		public PackageItemInfo(android.content.pm.PackageItemInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo1878, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageItemInfo1879;
		protected PackageItemInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageItemInfo.staticClass, global::android.content.pm.PackageItemInfo._PackageItemInfo1879, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _name1880;
		public global::java.lang.String name
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _packageName1881;
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
		internal static global::net.sf.jni4net.jni.FieldId _labelRes1882;
		public int labelRes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedLabel1883;
		public global::java.lang.CharSequence nonLocalizedLabel
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _icon1884;
		public int icon
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _metaData1885;
		public global::android.os.Bundle metaData
		{
			get
			{
				return default(global::android.os.Bundle);
			}
			set
			{
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.PackageItemInfo.staticClass = @__class;
			global::android.content.pm.PackageItemInfo._writeToParcel1871 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageItemInfo._loadLabel1872 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PackageItemInfo._loadIcon1873 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.PackageItemInfo._loadXmlMetaData1874 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.pm.PackageItemInfo._dumpFront1875 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.PackageItemInfo._dumpBack1876 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo1877 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo1878 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/content/pm/PackageItemInfo;)V");
			global::android.content.pm.PackageItemInfo._PackageItemInfo1879 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}

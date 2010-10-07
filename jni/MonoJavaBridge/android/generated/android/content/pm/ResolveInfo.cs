namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ResolveInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ResolveInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ResolveInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.ResolveInfo(@__env);
			}
		}
		protected ResolveInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class DisplayNameComparator : java.lang.Object, java.util.Comparator
		{
			internal static global::java.lang.Class staticClass;
			static DisplayNameComparator()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ResolveInfo.DisplayNameComparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.pm.ResolveInfo.DisplayNameComparator(@__env);
				}
			}
			protected DisplayNameComparator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _compare2002;
			public virtual int compare(android.content.pm.ResolveInfo arg0, android.content.pm.ResolveInfo arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _compare2003;
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2003, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2003, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _DisplayNameComparator2004;
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator2004, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass = @__class;
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2002 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare2003 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator2004 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString2005;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ResolveInfo._toString2005));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._toString2005));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump2006;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ResolveInfo._dump2006, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._dump2006, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2007;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ResolveInfo._writeToParcel2007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._writeToParcel2007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2008;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ResolveInfo._describeContents2008);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._describeContents2008);
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel2009;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ResolveInfo._loadLabel2009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadLabel2009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon2010;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ResolveInfo._loadIcon2010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._loadIcon2010, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIconResource2011;
		public virtual int getIconResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ResolveInfo._getIconResource2011);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._getIconResource2011);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ResolveInfo2012;
		public ResolveInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ResolveInfo.staticClass, global::android.content.pm.ResolveInfo._ResolveInfo2012, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _activityInfo2013;
		public global::android.content.pm.ActivityInfo activityInfo
		{
			get
			{
				return default(global::android.content.pm.ActivityInfo);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _serviceInfo2014;
		public global::android.content.pm.ServiceInfo serviceInfo
		{
			get
			{
				return default(global::android.content.pm.ServiceInfo);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _filter2015;
		public global::android.content.IntentFilter filter
		{
			get
			{
				return default(global::android.content.IntentFilter);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _priority2016;
		public int priority
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _preferredOrder2017;
		public int preferredOrder
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _match2018;
		public int match
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _specificIndex2019;
		public int specificIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _isDefault2020;
		public bool isDefault
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _labelRes2021;
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
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedLabel2022;
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
		internal static global::net.sf.jni4net.jni.FieldId _icon2023;
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
		internal static global::net.sf.jni4net.jni.FieldId _resolvePackageName2024;
		public global::java.lang.String resolvePackageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2025;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.ResolveInfo.staticClass = @__class;
			global::android.content.pm.ResolveInfo._toString2005 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ResolveInfo._dump2006 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ResolveInfo._writeToParcel2007 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ResolveInfo._describeContents2008 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ResolveInfo._loadLabel2009 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ResolveInfo._loadIcon2010 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.ResolveInfo._getIconResource2011 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ResolveInfo._ResolveInfo2012 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "<init>", "()V");
		}
	}
}

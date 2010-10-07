namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ComponentInfo : android.content.pm.PackageItemInfo
	{
		internal new static global::java.lang.Class staticClass;
		static ComponentInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ComponentInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.ComponentInfo(@__env);
			}
		}
		protected ComponentInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1786;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ComponentInfo._writeToParcel1786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._writeToParcel1786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1787;
		public override global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ComponentInfo._loadLabel1787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._loadLabel1787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpFront1788;
		protected override void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ComponentInfo._dumpFront1788, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpFront1788, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpBack1789;
		protected override void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ComponentInfo._dumpBack1789, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._dumpBack1789, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIconResource1790;
		public virtual int getIconResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ComponentInfo._getIconResource1790);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._getIconResource1790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentInfo1791;
		public ComponentInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo1791, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentInfo1792;
		public ComponentInfo(android.content.pm.ComponentInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo1792, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ComponentInfo1793;
		protected ComponentInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ComponentInfo.staticClass, global::android.content.pm.ComponentInfo._ComponentInfo1793, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _applicationInfo1794;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				return default(global::android.content.pm.ApplicationInfo);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _processName1795;
		public global::java.lang.String processName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1796;
		public int descriptionRes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _enabled1797;
		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _exported1798;
		public bool exported
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.ComponentInfo.staticClass = @__class;
			global::android.content.pm.ComponentInfo._writeToParcel1786 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ComponentInfo._loadLabel1787 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.ComponentInfo._dumpFront1788 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._dumpBack1789 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ComponentInfo._getIconResource1790 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "getIconResource", "()I");
			global::android.content.pm.ComponentInfo._ComponentInfo1791 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ComponentInfo._ComponentInfo1792 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/content/pm/ComponentInfo;)V");
			global::android.content.pm.ComponentInfo._ComponentInfo1793 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}

namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ComponentInfo : android.content.pm.PackageItemInfo
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ComponentInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ComponentInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1566; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ComponentInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ComponentInfo.staticClass, _writeToParcel1566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1567; 
		public override java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ComponentInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadLabel1567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ComponentInfo.staticClass, _loadLabel1567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon1568; 
		public override android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ComponentInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadIcon1568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ComponentInfo.staticClass, _loadIcon1568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpFront1569; 
		protected override void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ComponentInfo)) 
				@__env.CallVoidMethod(this, _dumpFront1569, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ComponentInfo.staticClass, _dumpFront1569, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpBack1570; 
		protected override void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ComponentInfo)) 
				@__env.CallVoidMethod(this, _dumpBack1570, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ComponentInfo.staticClass, _dumpBack1570, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIconResource1571; 
		public virtual int getIconResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ComponentInfo)) 
				return @__env.CallIntMethod(this, _getIconResource1571); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ComponentInfo.staticClass, _getIconResource1571); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentInfo1572; 
		public ComponentInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ComponentInfo.staticClass, _ComponentInfo1572, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentInfo1573; 
		public ComponentInfo(android.content.pm.ComponentInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ComponentInfo.staticClass, _ComponentInfo1573, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentInfo1574; 
		protected ComponentInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ComponentInfo.staticClass, _ComponentInfo1574, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _applicationInfo1575; 
		public android.content.pm.ApplicationInfo applicationInfo
		{ 
			get 
			{ 
				return default(android.content.pm.ApplicationInfo); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _processName1576; 
		public java.lang.String processName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _enabled1577; 
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
		internal static global::net.sf.jni4net.jni.FieldId _exported1578; 
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
			global::android.content.pm.ComponentInfo._writeToParcel1566 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.ComponentInfo._loadLabel1567 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.ComponentInfo._loadIcon1568 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.ComponentInfo._dumpFront1569 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.ComponentInfo._dumpBack1570 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.ComponentInfo._getIconResource1571 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "getIconResource", "()I"); 
			global::android.content.pm.ComponentInfo._ComponentInfo1572 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.ComponentInfo._ComponentInfo1573 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/content/pm/ComponentInfo;)V"); 
			global::android.content.pm.ComponentInfo._ComponentInfo1574 = @__env.GetMethodID(global::android.content.pm.ComponentInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 

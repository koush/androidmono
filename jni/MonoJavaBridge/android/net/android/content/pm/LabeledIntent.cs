namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LabeledIntent : android.content.Intent
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LabeledIntent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.LabeledIntent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.LabeledIntent(@__env); 
			} 
		} 
		protected LabeledIntent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1613; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				@__env.CallVoidMethod(this, _writeToParcel1613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.LabeledIntent.staticClass, _writeToParcel1613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel1614; 
		public override void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				@__env.CallVoidMethod(this, _readFromParcel1614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.LabeledIntent.staticClass, _readFromParcel1614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1615; 
		public virtual java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadLabel1615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.LabeledIntent.staticClass, _loadLabel1615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon1616; 
		public virtual android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadIcon1616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.LabeledIntent.staticClass, _loadIcon1616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIconResource1617; 
		public virtual int getIconResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return @__env.CallIntMethod(this, _getIconResource1617); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.LabeledIntent.staticClass, _getIconResource1617); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSourcePackage1618; 
		public virtual java.lang.String getSourcePackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSourcePackage1618)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.LabeledIntent.staticClass, _getSourcePackage1618)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLabelResource1619; 
		public virtual int getLabelResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return @__env.CallIntMethod(this, _getLabelResource1619); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.LabeledIntent.staticClass, _getLabelResource1619); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNonLocalizedLabel1620; 
		public virtual java.lang.CharSequence getNonLocalizedLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getNonLocalizedLabel1620)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.LabeledIntent.staticClass, _getNonLocalizedLabel1620)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1621; 
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, _LabeledIntent1621, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1622; 
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, java.lang.CharSequence arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, _LabeledIntent1622, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1623; 
		public LabeledIntent(java.lang.String arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, _LabeledIntent1623, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1624; 
		public LabeledIntent(java.lang.String arg0, java.lang.CharSequence arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, _LabeledIntent1624, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1625; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.LabeledIntent.staticClass = @__class; 
			global::android.content.pm.LabeledIntent._writeToParcel1613 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.LabeledIntent._readFromParcel1614 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.content.pm.LabeledIntent._loadLabel1615 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.LabeledIntent._loadIcon1616 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.LabeledIntent._getIconResource1617 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getIconResource", "()I"); 
			global::android.content.pm.LabeledIntent._getSourcePackage1618 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getSourcePackage", "()Ljava/lang/String;"); 
			global::android.content.pm.LabeledIntent._getLabelResource1619 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getLabelResource", "()I"); 
			global::android.content.pm.LabeledIntent._getNonLocalizedLabel1620 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getNonLocalizedLabel", "()Ljava/lang/CharSequence;"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1621 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1622 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1623 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;II)V"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1624 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V"); 
		} 
	} 
} 

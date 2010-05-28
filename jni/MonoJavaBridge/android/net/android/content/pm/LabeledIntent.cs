namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LabeledIntent : android.content.Intent
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LabeledIntent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.LabeledIntent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1658; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				@__env.CallVoidMethod(this, global::android.content.pm.LabeledIntent._writeToParcel1658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._writeToParcel1658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel1659; 
		public override void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				@__env.CallVoidMethod(this, global::android.content.pm.LabeledIntent._readFromParcel1659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._readFromParcel1659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1660; 
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.LabeledIntent._loadLabel1660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadLabel1660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon1661; 
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.LabeledIntent._loadIcon1661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadIcon1661, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIconResource1662; 
		public virtual int getIconResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return @__env.CallIntMethod(this, global::android.content.pm.LabeledIntent._getIconResource1662); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getIconResource1662); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSourcePackage1663; 
		public virtual global::java.lang.String getSourcePackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.LabeledIntent._getSourcePackage1663)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getSourcePackage1663)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLabelResource1664; 
		public virtual int getLabelResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return @__env.CallIntMethod(this, global::android.content.pm.LabeledIntent._getLabelResource1664); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getLabelResource1664); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNonLocalizedLabel1665; 
		public virtual global::java.lang.CharSequence getNonLocalizedLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.LabeledIntent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.LabeledIntent._getNonLocalizedLabel1665)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getNonLocalizedLabel1665)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1666; 
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1666, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1667; 
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, java.lang.CharSequence arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1667, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1668; 
		public LabeledIntent(java.lang.String arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1668, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LabeledIntent1669; 
		public LabeledIntent(java.lang.String arg0, java.lang.CharSequence arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent1669, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1670; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.LabeledIntent.staticClass = @__class; 
			global::android.content.pm.LabeledIntent._writeToParcel1658 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.LabeledIntent._readFromParcel1659 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.content.pm.LabeledIntent._loadLabel1660 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.LabeledIntent._loadIcon1661 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.LabeledIntent._getIconResource1662 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getIconResource", "()I"); 
			global::android.content.pm.LabeledIntent._getSourcePackage1663 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getSourcePackage", "()Ljava/lang/String;"); 
			global::android.content.pm.LabeledIntent._getLabelResource1664 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getLabelResource", "()I"); 
			global::android.content.pm.LabeledIntent._getNonLocalizedLabel1665 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "getNonLocalizedLabel", "()Ljava/lang/CharSequence;"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1666 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1667 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1668 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;II)V"); 
			global::android.content.pm.LabeledIntent._LabeledIntent1669 = @__env.GetMethodID(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V"); 
		} 
	} 
} 

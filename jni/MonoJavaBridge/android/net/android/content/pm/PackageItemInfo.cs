namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PackageItemInfo : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PackageItemInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PackageItemInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PackageItemInfo.DisplayNameComparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _compare1648; 
			public virtual int compare(android.content.pm.PackageItemInfo arg0, android.content.pm.PackageItemInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.pm.PackageItemInfo.DisplayNameComparator)) 
					return @__env.CallIntMethod(this, _compare1648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, _compare1648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _compare1649; 
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.pm.PackageItemInfo.DisplayNameComparator)) 
					return @__env.CallIntMethod(this, _compare1649, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, _compare1649, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DisplayNameComparator1650; 
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, _DisplayNameComparator1650, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass = @__class; 
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1648 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I"); 
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._compare1649 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"); 
				global::android.content.pm.PackageItemInfo.DisplayNameComparator._DisplayNameComparator1650 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1651; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageItemInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PackageItemInfo.staticClass, _writeToParcel1651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1652; 
		public virtual java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageItemInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadLabel1652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PackageItemInfo.staticClass, _loadLabel1652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon1653; 
		public virtual android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageItemInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadIcon1653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PackageItemInfo.staticClass, _loadIcon1653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadXmlMetaData1654; 
		public virtual android.content.res.XmlResourceParser loadXmlMetaData(android.content.pm.PackageManager arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageItemInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallObjectMethodPtr(this, _loadXmlMetaData1654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.res.XmlResourceParser>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PackageItemInfo.staticClass, _loadXmlMetaData1654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpFront1655; 
		protected virtual void dumpFront(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageItemInfo)) 
				@__env.CallVoidMethod(this, _dumpFront1655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PackageItemInfo.staticClass, _dumpFront1655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpBack1656; 
		protected virtual void dumpBack(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageItemInfo)) 
				@__env.CallVoidMethod(this, _dumpBack1656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PackageItemInfo.staticClass, _dumpBack1656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PackageItemInfo1657; 
		public PackageItemInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PackageItemInfo.staticClass, _PackageItemInfo1657, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PackageItemInfo1658; 
		public PackageItemInfo(android.content.pm.PackageItemInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PackageItemInfo.staticClass, _PackageItemInfo1658, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PackageItemInfo1659; 
		protected PackageItemInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PackageItemInfo.staticClass, _PackageItemInfo1659, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _name1660; 
		public java.lang.String name
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _packageName1661; 
		public java.lang.String packageName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _labelRes1662; 
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
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedLabel1663; 
		public java.lang.CharSequence nonLocalizedLabel
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _icon1664; 
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
		internal static global::net.sf.jni4net.jni.FieldId _metaData1665; 
		public android.os.Bundle metaData
		{ 
			get 
			{ 
				return default(android.os.Bundle); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.PackageItemInfo.staticClass = @__class; 
			global::android.content.pm.PackageItemInfo._writeToParcel1651 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.PackageItemInfo._loadLabel1652 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.PackageItemInfo._loadIcon1653 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.PackageItemInfo._loadXmlMetaData1654 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlResourceParser;"); 
			global::android.content.pm.PackageItemInfo._dumpFront1655 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.PackageItemInfo._dumpBack1656 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.PackageItemInfo._PackageItemInfo1657 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.PackageItemInfo._PackageItemInfo1658 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/content/pm/PackageItemInfo;)V"); 
			global::android.content.pm.PackageItemInfo._PackageItemInfo1659 = @__env.GetMethodID(global::android.content.pm.PackageItemInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 

namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ResolveInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ResolveInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ResolveInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ResolveInfo.DisplayNameComparator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _compare1779; 
			public virtual int compare(android.content.pm.ResolveInfo arg0, android.content.pm.ResolveInfo arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.pm.ResolveInfo.DisplayNameComparator)) 
					return @__env.CallIntMethod(this, _compare1779, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, _compare1779, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _compare1780; 
			public virtual int compare(java.lang.Object arg0, java.lang.Object arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.pm.ResolveInfo.DisplayNameComparator)) 
					return @__env.CallIntMethod(this, _compare1780, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, _compare1780, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _DisplayNameComparator1781; 
			public DisplayNameComparator(android.content.pm.PackageManager arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, _DisplayNameComparator1781, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass = @__class; 
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare1779 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I"); 
				global::android.content.pm.ResolveInfo.DisplayNameComparator._compare1780 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"); 
				global::android.content.pm.ResolveInfo.DisplayNameComparator._DisplayNameComparator1781 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.DisplayNameComparator.staticClass, "<init>", "(Landroid/content/pm/PackageManager;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1782; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1782)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ResolveInfo.staticClass, _toString1782)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump1783; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				@__env.CallVoidMethod(this, _dump1783, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ResolveInfo.staticClass, _dump1783, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1784; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ResolveInfo.staticClass, _writeToParcel1784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1785; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				return @__env.CallIntMethod(this, _describeContents1785); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ResolveInfo.staticClass, _describeContents1785); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel1786; 
		public virtual java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadLabel1786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ResolveInfo.staticClass, _loadLabel1786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon1787; 
		public virtual android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadIcon1787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ResolveInfo.staticClass, _loadIcon1787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIconResource1788; 
		public virtual int getIconResource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ResolveInfo)) 
				return @__env.CallIntMethod(this, _getIconResource1788); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ResolveInfo.staticClass, _getIconResource1788); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ResolveInfo1789; 
		public ResolveInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ResolveInfo.staticClass, _ResolveInfo1789, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _activityInfo1790; 
		public android.content.pm.ActivityInfo activityInfo
		{ 
			get 
			{ 
				return default(android.content.pm.ActivityInfo); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _serviceInfo1791; 
		public android.content.pm.ServiceInfo serviceInfo
		{ 
			get 
			{ 
				return default(android.content.pm.ServiceInfo); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _filter1792; 
		public android.content.IntentFilter filter
		{ 
			get 
			{ 
				return default(android.content.IntentFilter); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _priority1793; 
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
		internal static global::net.sf.jni4net.jni.FieldId _preferredOrder1794; 
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
		internal static global::net.sf.jni4net.jni.FieldId _match1795; 
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
		internal static global::net.sf.jni4net.jni.FieldId _specificIndex1796; 
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
		internal static global::net.sf.jni4net.jni.FieldId _isDefault1797; 
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
		internal static global::net.sf.jni4net.jni.FieldId _labelRes1798; 
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
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedLabel1799; 
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
		internal static global::net.sf.jni4net.jni.FieldId _icon1800; 
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
		internal static global::net.sf.jni4net.jni.FieldId _resolvePackageName1801; 
		public java.lang.String resolvePackageName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1802; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.ResolveInfo.staticClass = @__class; 
			global::android.content.pm.ResolveInfo._toString1782 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.ResolveInfo._dump1783 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.ResolveInfo._writeToParcel1784 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.ResolveInfo._describeContents1785 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.ResolveInfo._loadLabel1786 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.ResolveInfo._loadIcon1787 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.content.pm.ResolveInfo._getIconResource1788 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "getIconResource", "()I"); 
			global::android.content.pm.ResolveInfo._ResolveInfo1789 = @__env.GetMethodID(global::android.content.pm.ResolveInfo.staticClass, "<init>", "()V"); 
		} 
	} 
} 

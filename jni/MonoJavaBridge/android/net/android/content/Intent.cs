namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Intent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Intent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.Intent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.Intent(@__env); 
			} 
		} 
		protected Intent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class FilterComparison : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static FilterComparison() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.Intent.FilterComparison), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.Intent.FilterComparison(@__env); 
				} 
			} 
			internal FilterComparison(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _hashCode1257; 
			public sealed override int hashCode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.Intent.FilterComparison)) 
					return @__env.CallIntMethod(this, _hashCode1257); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.Intent.FilterComparison.staticClass, _hashCode1257); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _equals1258; 
			public sealed override bool equals(java.lang.Object arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.Intent.FilterComparison)) 
					return @__env.CallBooleanMethod(this, _equals1258, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.content.Intent.FilterComparison.staticClass, _equals1258, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getIntent1259; 
			public android.content.Intent getIntent() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.Intent.FilterComparison)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _getIntent1259)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.FilterComparison.staticClass, _getIntent1259)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _FilterComparison1260; 
			public FilterComparison(android.content.Intent arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.Intent.FilterComparison.staticClass, _FilterComparison1260, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.Intent.FilterComparison.staticClass = @__class; 
				global::android.content.Intent.FilterComparison._hashCode1257 = @__env.GetMethodID(global::android.content.Intent.FilterComparison.staticClass, "hashCode", "()I"); 
				global::android.content.Intent.FilterComparison._equals1258 = @__env.GetMethodID(global::android.content.Intent.FilterComparison.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
				global::android.content.Intent.FilterComparison._getIntent1259 = @__env.GetMethodID(global::android.content.Intent.FilterComparison.staticClass, "getIntent", "()Landroid/content/Intent;"); 
				global::android.content.Intent.FilterComparison._FilterComparison1260 = @__env.GetMethodID(global::android.content.Intent.FilterComparison.staticClass, "<init>", "(Landroid/content/Intent;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class ShortcutIconResource : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static ShortcutIconResource() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.Intent.ShortcutIconResource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.Intent.ShortcutIconResource(@__env); 
				} 
			} 
			protected ShortcutIconResource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString1261; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.Intent.ShortcutIconResource)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1261)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.ShortcutIconResource.staticClass, _toString1261)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1262; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.Intent.ShortcutIconResource)) 
					@__env.CallVoidMethod(this, _writeToParcel1262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.Intent.ShortcutIconResource.staticClass, _writeToParcel1262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents1263; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.Intent.ShortcutIconResource)) 
					return @__env.CallIntMethod(this, _describeContents1263); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.Intent.ShortcutIconResource.staticClass, _describeContents1263); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _fromContext1264; 
			public static android.content.Intent.ShortcutIconResource fromContext(android.content.Context arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent.ShortcutIconResource>(@__env, @__env.CallStaticObjectMethodPtr(android.content.Intent.ShortcutIconResource.staticClass, _fromContext1264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ShortcutIconResource1265; 
			public ShortcutIconResource()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.Intent.ShortcutIconResource.staticClass, _ShortcutIconResource1265, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _packageName1266; 
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
			internal static global::net.sf.jni4net.jni.FieldId _resourceName1267; 
			public java.lang.String resourceName
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR1268; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.Intent.ShortcutIconResource.staticClass = @__class; 
				global::android.content.Intent.ShortcutIconResource._toString1261 = @__env.GetMethodID(global::android.content.Intent.ShortcutIconResource.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.content.Intent.ShortcutIconResource._writeToParcel1262 = @__env.GetMethodID(global::android.content.Intent.ShortcutIconResource.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.content.Intent.ShortcutIconResource._describeContents1263 = @__env.GetMethodID(global::android.content.Intent.ShortcutIconResource.staticClass, "describeContents", "()I"); 
				global::android.content.Intent.ShortcutIconResource._fromContext1264 = @__env.GetStaticMethodID(global::android.content.Intent.ShortcutIconResource.staticClass, "fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;"); 
				global::android.content.Intent.ShortcutIconResource._ShortcutIconResource1265 = @__env.GetMethodID(global::android.content.Intent.ShortcutIconResource.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone1269; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone1269)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _clone1269)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1270; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1270)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _toString1270)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackage1271; 
		public virtual java.lang.String getPackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackage1271)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getPackage1271)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType1272; 
		public virtual java.lang.String getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getType1272)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getType1272)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toURI1273; 
		public virtual java.lang.String toURI() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toURI1273)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _toURI1273)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScheme1274; 
		public virtual java.lang.String getScheme() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getScheme1274)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getScheme1274)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getData1275; 
		public virtual android.net.Uri getData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallObjectMethodPtr(this, _getData1275)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.Uri>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getData1275)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComponent1276; 
		public virtual android.content.ComponentName getComponent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _getComponent1276)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getComponent1276)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClassName1277; 
		public virtual android.content.Intent setClassName(android.content.Context arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setClassName1277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setClassName1277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClassName1278; 
		public virtual android.content.Intent setClassName(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setClassName1278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setClassName1278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1279; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				@__env.CallVoidMethod(this, _writeToParcel1279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.Intent.staticClass, _writeToParcel1279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1280; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallIntMethod(this, _describeContents1280); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.Intent.staticClass, _describeContents1280); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createChooser1281; 
		public static android.content.Intent createChooser(android.content.Intent arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallStaticObjectMethodPtr(android.content.Intent.staticClass, _createChooser1281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cloneFilter1282; 
		public virtual android.content.Intent cloneFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _cloneFilter1282)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _cloneFilter1282)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntent1283; 
		public static android.content.Intent getIntent(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallStaticObjectMethodPtr(android.content.Intent.staticClass, _getIntent1283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseUri1284; 
		public static android.content.Intent parseUri(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallStaticObjectMethodPtr(android.content.Intent.staticClass, _parseUri1284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntentOld1285; 
		public static android.content.Intent getIntentOld(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallStaticObjectMethodPtr(android.content.Intent.staticClass, _getIntentOld1285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAction1286; 
		public virtual java.lang.String getAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAction1286)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getAction1286)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataString1287; 
		public virtual java.lang.String getDataString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDataString1287)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getDataString1287)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveType1288; 
		public virtual java.lang.String resolveType(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _resolveType1288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _resolveType1288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveType1289; 
		public virtual java.lang.String resolveType(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _resolveType1289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _resolveType1289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveTypeIfNeeded1290; 
		public virtual java.lang.String resolveTypeIfNeeded(android.content.ContentResolver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _resolveTypeIfNeeded1290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _resolveTypeIfNeeded1290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasCategory1291; 
		public virtual bool hasCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallBooleanMethod(this, _hasCategory1291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.Intent.staticClass, _hasCategory1291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCategories1292; 
		public virtual java.util.Set getCategories() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _getCategories1292)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getCategories1292)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtrasClassLoader1293; 
		public virtual void setExtrasClassLoader(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				@__env.CallVoidMethod(this, _setExtrasClassLoader1293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.Intent.staticClass, _setExtrasClassLoader1293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasExtra1294; 
		public virtual bool hasExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallBooleanMethod(this, _hasExtra1294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.Intent.staticClass, _hasExtra1294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors1295; 
		public virtual bool hasFileDescriptors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallBooleanMethod(this, _hasFileDescriptors1295); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.Intent.staticClass, _hasFileDescriptors1295); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBooleanExtra1296; 
		public virtual bool getBooleanExtra(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallBooleanMethod(this, _getBooleanExtra1296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.Intent.staticClass, _getBooleanExtra1296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByteExtra1297; 
		public virtual byte getByteExtra(java.lang.String arg0, byte arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallByteMethod(this, _getByteExtra1297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualByteMethod(this, android.content.Intent.staticClass, _getByteExtra1297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShortExtra1298; 
		public virtual short getShortExtra(java.lang.String arg0, short arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallShortMethod(this, _getShortExtra1298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.content.Intent.staticClass, _getShortExtra1298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharExtra1299; 
		public virtual char getCharExtra(java.lang.String arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallCharMethod(this, _getCharExtra1299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.content.Intent.staticClass, _getCharExtra1299, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntExtra1300; 
		public virtual int getIntExtra(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallIntMethod(this, _getIntExtra1300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.Intent.staticClass, _getIntExtra1300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongExtra1301; 
		public virtual long getLongExtra(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallLongMethod(this, _getLongExtra1301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.content.Intent.staticClass, _getLongExtra1301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloatExtra1302; 
		public virtual float getFloatExtra(java.lang.String arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallFloatMethod(this, _getFloatExtra1302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.content.Intent.staticClass, _getFloatExtra1302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleExtra1303; 
		public virtual double getDoubleExtra(java.lang.String arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallDoubleMethod(this, _getDoubleExtra1303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.content.Intent.staticClass, _getDoubleExtra1303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringExtra1304; 
		public virtual java.lang.String getStringExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getStringExtra1304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getStringExtra1304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharSequenceExtra1305; 
		public virtual java.lang.CharSequence getCharSequenceExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getCharSequenceExtra1305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getCharSequenceExtra1305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableExtra1306; 
		public virtual android.os.Parcelable getParcelableExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _getParcelableExtra1306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getParcelableExtra1306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArrayExtra1307; 
		public virtual android.os.Parcelable[] getParcelableArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getParcelableArrayExtra1307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getParcelableArrayExtra1307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArrayListExtra1308; 
		public virtual java.util.ArrayList getParcelableArrayListExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getParcelableArrayListExtra1308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getParcelableArrayListExtra1308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSerializableExtra1309; 
		public virtual java.io.Serializable getSerializableExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, _getSerializableExtra1309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getSerializableExtra1309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerArrayListExtra1310; 
		public virtual java.util.ArrayList getIntegerArrayListExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getIntegerArrayListExtra1310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getIntegerArrayListExtra1310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringArrayListExtra1311; 
		public virtual java.util.ArrayList getStringArrayListExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getStringArrayListExtra1311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getStringArrayListExtra1311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBooleanArrayExtra1312; 
		public virtual bool[] getBooleanArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBooleanArrayExtra1312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getBooleanArrayExtra1312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByteArrayExtra1313; 
		public virtual byte[] getByteArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getByteArrayExtra1313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getByteArrayExtra1313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShortArrayExtra1314; 
		public virtual short[] getShortArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getShortArrayExtra1314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getShortArrayExtra1314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharArrayExtra1315; 
		public virtual char[] getCharArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCharArrayExtra1315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getCharArrayExtra1315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntArrayExtra1316; 
		public virtual int[] getIntArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getIntArrayExtra1316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getIntArrayExtra1316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongArrayExtra1317; 
		public virtual long[] getLongArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getLongArrayExtra1317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getLongArrayExtra1317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloatArrayExtra1318; 
		public virtual float[] getFloatArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getFloatArrayExtra1318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getFloatArrayExtra1318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleArrayExtra1319; 
		public virtual double[] getDoubleArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getDoubleArrayExtra1319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getDoubleArrayExtra1319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringArrayExtra1320; 
		public virtual java.lang.String[] getStringArrayExtra(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.Intent)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getStringArrayExtra1320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getStringArrayExtra1320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBundleExtra1321; 
		public virtual android.os.Bundle getBundleExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getBundleExtra1321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getBundleExtra1321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras1322; 
		public virtual android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getExtras1322)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getExtras1322)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFlags1323; 
		public virtual int getFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallIntMethod(this, _getFlags1323); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.Intent.staticClass, _getFlags1323); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSourceBounds1324; 
		public virtual android.graphics.Rect getSourceBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, _getSourceBounds1324)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _getSourceBounds1324)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveActivity1325; 
		public virtual android.content.ComponentName resolveActivity(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _resolveActivity1325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _resolveActivity1325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveActivityInfo1326; 
		public virtual android.content.pm.ActivityInfo resolveActivityInfo(android.content.pm.PackageManager arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ActivityInfo>(@__env, @__env.CallObjectMethodPtr(this, _resolveActivityInfo1326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ActivityInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _resolveActivityInfo1326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAction1327; 
		public virtual android.content.Intent setAction(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setAction1327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setAction1327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setData1328; 
		public virtual android.content.Intent setData(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setData1328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setData1328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setType1329; 
		public virtual android.content.Intent setType(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setType1329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setType1329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataAndType1330; 
		public virtual android.content.Intent setDataAndType(android.net.Uri arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setDataAndType1330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setDataAndType1330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addCategory1331; 
		public virtual android.content.Intent addCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _addCategory1331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _addCategory1331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCategory1332; 
		public virtual void removeCategory(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				@__env.CallVoidMethod(this, _removeCategory1332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.Intent.staticClass, _removeCategory1332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1333; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1334; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1335; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, byte arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1336; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1336, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1337; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, short arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1338; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1338, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1339; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1339, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1340; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1341; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1342; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1343; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1344; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1345; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1346; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, java.io.Serializable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1347; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, bool[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1348; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, short[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1349; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, char[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1350; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1351; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, long[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1352; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1353; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, double[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1354; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtra1355; 
		public virtual android.content.Intent putExtra(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtra1355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtra1355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArrayListExtra1356; 
		public virtual android.content.Intent putParcelableArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putParcelableArrayListExtra1356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putParcelableArrayListExtra1356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putIntegerArrayListExtra1357; 
		public virtual android.content.Intent putIntegerArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putIntegerArrayListExtra1357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putIntegerArrayListExtra1357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putStringArrayListExtra1358; 
		public virtual android.content.Intent putStringArrayListExtra(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putStringArrayListExtra1358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putStringArrayListExtra1358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtras1359; 
		public virtual android.content.Intent putExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtras1359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtras1359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putExtras1360; 
		public virtual android.content.Intent putExtras(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _putExtras1360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _putExtras1360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceExtras1361; 
		public virtual android.content.Intent replaceExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _replaceExtras1361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _replaceExtras1361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceExtras1362; 
		public virtual android.content.Intent replaceExtras(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _replaceExtras1362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _replaceExtras1362, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeExtra1363; 
		public virtual void removeExtra(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				@__env.CallVoidMethod(this, _removeExtra1363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.Intent.staticClass, _removeExtra1363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlags1364; 
		public virtual android.content.Intent setFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setFlags1364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setFlags1364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFlags1365; 
		public virtual android.content.Intent addFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _addFlags1365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _addFlags1365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPackage1366; 
		public virtual android.content.Intent setPackage(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setPackage1366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setPackage1366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setComponent1367; 
		public virtual android.content.Intent setComponent(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setComponent1367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setComponent1367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClass1368; 
		public virtual android.content.Intent setClass(android.content.Context arg0, java.lang.Class arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _setClass1368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _setClass1368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSourceBounds1369; 
		public virtual void setSourceBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				@__env.CallVoidMethod(this, _setSourceBounds1369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.Intent.staticClass, _setSourceBounds1369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillIn1370; 
		public virtual int fillIn(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallIntMethod(this, _fillIn1370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.Intent.staticClass, _fillIn1370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _filterEquals1371; 
		public virtual bool filterEquals(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallBooleanMethod(this, _filterEquals1371, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.Intent.staticClass, _filterEquals1371, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _filterHashCode1372; 
		public virtual int filterHashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return @__env.CallIntMethod(this, _filterHashCode1372); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.Intent.staticClass, _filterHashCode1372); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toUri1373; 
		public virtual java.lang.String toUri(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toUri1373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.Intent.staticClass, _toUri1373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel1374; 
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.Intent)) 
				@__env.CallVoidMethod(this, _readFromParcel1374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.Intent.staticClass, _readFromParcel1374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseIntent1375; 
		public static android.content.Intent parseIntent(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallStaticObjectMethodPtr(android.content.Intent.staticClass, _parseIntent1375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Intent1376; 
		public Intent(java.lang.String arg0, android.net.Uri arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Intent.staticClass, _Intent1376, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Intent1377; 
		public Intent(android.content.Intent arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Intent.staticClass, _Intent1377, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Intent1378; 
		public Intent(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Intent.staticClass, _Intent1378, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Intent1379; 
		public Intent()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Intent.staticClass, _Intent1379, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Intent1380; 
		public Intent(android.content.Context arg0, java.lang.Class arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Intent.staticClass, _Intent1380, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Intent1381; 
		public Intent(java.lang.String arg0, android.net.Uri arg1, android.content.Context arg2, java.lang.Class arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.Intent.staticClass, _Intent1381, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		public static java.lang.String ACTION_MAIN
		{ 
			get 
			{ 
				return "android.intent.action.MAIN"; 
			} 
		} 
		public static java.lang.String ACTION_VIEW
		{ 
			get 
			{ 
				return "android.intent.action.VIEW"; 
			} 
		} 
		public static java.lang.String ACTION_DEFAULT
		{ 
			get 
			{ 
				return "android.intent.action.VIEW"; 
			} 
		} 
		public static java.lang.String ACTION_ATTACH_DATA
		{ 
			get 
			{ 
				return "android.intent.action.ATTACH_DATA"; 
			} 
		} 
		public static java.lang.String ACTION_EDIT
		{ 
			get 
			{ 
				return "android.intent.action.EDIT"; 
			} 
		} 
		public static java.lang.String ACTION_INSERT_OR_EDIT
		{ 
			get 
			{ 
				return "android.intent.action.INSERT_OR_EDIT"; 
			} 
		} 
		public static java.lang.String ACTION_PICK
		{ 
			get 
			{ 
				return "android.intent.action.PICK"; 
			} 
		} 
		public static java.lang.String ACTION_CREATE_SHORTCUT
		{ 
			get 
			{ 
				return "android.intent.action.CREATE_SHORTCUT"; 
			} 
		} 
		public static java.lang.String EXTRA_SHORTCUT_INTENT
		{ 
			get 
			{ 
				return "android.intent.extra.shortcut.INTENT"; 
			} 
		} 
		public static java.lang.String EXTRA_SHORTCUT_NAME
		{ 
			get 
			{ 
				return "android.intent.extra.shortcut.NAME"; 
			} 
		} 
		public static java.lang.String EXTRA_SHORTCUT_ICON
		{ 
			get 
			{ 
				return "android.intent.extra.shortcut.ICON"; 
			} 
		} 
		public static java.lang.String EXTRA_SHORTCUT_ICON_RESOURCE
		{ 
			get 
			{ 
				return "android.intent.extra.shortcut.ICON_RESOURCE"; 
			} 
		} 
		public static java.lang.String ACTION_CHOOSER
		{ 
			get 
			{ 
				return "android.intent.action.CHOOSER"; 
			} 
		} 
		public static java.lang.String ACTION_GET_CONTENT
		{ 
			get 
			{ 
				return "android.intent.action.GET_CONTENT"; 
			} 
		} 
		public static java.lang.String ACTION_DIAL
		{ 
			get 
			{ 
				return "android.intent.action.DIAL"; 
			} 
		} 
		public static java.lang.String ACTION_CALL
		{ 
			get 
			{ 
				return "android.intent.action.CALL"; 
			} 
		} 
		public static java.lang.String ACTION_SENDTO
		{ 
			get 
			{ 
				return "android.intent.action.SENDTO"; 
			} 
		} 
		public static java.lang.String ACTION_SEND
		{ 
			get 
			{ 
				return "android.intent.action.SEND"; 
			} 
		} 
		public static java.lang.String ACTION_SEND_MULTIPLE
		{ 
			get 
			{ 
				return "android.intent.action.SEND_MULTIPLE"; 
			} 
		} 
		public static java.lang.String ACTION_ANSWER
		{ 
			get 
			{ 
				return "android.intent.action.ANSWER"; 
			} 
		} 
		public static java.lang.String ACTION_INSERT
		{ 
			get 
			{ 
				return "android.intent.action.INSERT"; 
			} 
		} 
		public static java.lang.String ACTION_DELETE
		{ 
			get 
			{ 
				return "android.intent.action.DELETE"; 
			} 
		} 
		public static java.lang.String ACTION_RUN
		{ 
			get 
			{ 
				return "android.intent.action.RUN"; 
			} 
		} 
		public static java.lang.String ACTION_SYNC
		{ 
			get 
			{ 
				return "android.intent.action.SYNC"; 
			} 
		} 
		public static java.lang.String ACTION_PICK_ACTIVITY
		{ 
			get 
			{ 
				return "android.intent.action.PICK_ACTIVITY"; 
			} 
		} 
		public static java.lang.String ACTION_SEARCH
		{ 
			get 
			{ 
				return "android.intent.action.SEARCH"; 
			} 
		} 
		public static java.lang.String ACTION_SYSTEM_TUTORIAL
		{ 
			get 
			{ 
				return "android.intent.action.SYSTEM_TUTORIAL"; 
			} 
		} 
		public static java.lang.String ACTION_WEB_SEARCH
		{ 
			get 
			{ 
				return "android.intent.action.WEB_SEARCH"; 
			} 
		} 
		public static java.lang.String ACTION_ALL_APPS
		{ 
			get 
			{ 
				return "android.intent.action.ALL_APPS"; 
			} 
		} 
		public static java.lang.String ACTION_SET_WALLPAPER
		{ 
			get 
			{ 
				return "android.intent.action.SET_WALLPAPER"; 
			} 
		} 
		public static java.lang.String ACTION_BUG_REPORT
		{ 
			get 
			{ 
				return "android.intent.action.BUG_REPORT"; 
			} 
		} 
		public static java.lang.String ACTION_FACTORY_TEST
		{ 
			get 
			{ 
				return "android.intent.action.FACTORY_TEST"; 
			} 
		} 
		public static java.lang.String ACTION_CALL_BUTTON
		{ 
			get 
			{ 
				return "android.intent.action.CALL_BUTTON"; 
			} 
		} 
		public static java.lang.String ACTION_VOICE_COMMAND
		{ 
			get 
			{ 
				return "android.intent.action.VOICE_COMMAND"; 
			} 
		} 
		public static java.lang.String ACTION_SEARCH_LONG_PRESS
		{ 
			get 
			{ 
				return "android.intent.action.SEARCH_LONG_PRESS"; 
			} 
		} 
		public static java.lang.String ACTION_POWER_USAGE_SUMMARY
		{ 
			get 
			{ 
				return "android.intent.action.POWER_USAGE_SUMMARY"; 
			} 
		} 
		public static java.lang.String ACTION_SCREEN_OFF
		{ 
			get 
			{ 
				return "android.intent.action.SCREEN_OFF"; 
			} 
		} 
		public static java.lang.String ACTION_SCREEN_ON
		{ 
			get 
			{ 
				return "android.intent.action.SCREEN_ON"; 
			} 
		} 
		public static java.lang.String ACTION_USER_PRESENT
		{ 
			get 
			{ 
				return "android.intent.action.USER_PRESENT"; 
			} 
		} 
		public static java.lang.String ACTION_TIME_TICK
		{ 
			get 
			{ 
				return "android.intent.action.TIME_TICK"; 
			} 
		} 
		public static java.lang.String ACTION_TIME_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.TIME_SET"; 
			} 
		} 
		public static java.lang.String ACTION_DATE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.DATE_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_TIMEZONE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.TIMEZONE_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_BOOT_COMPLETED
		{ 
			get 
			{ 
				return "android.intent.action.BOOT_COMPLETED"; 
			} 
		} 
		public static java.lang.String ACTION_CLOSE_SYSTEM_DIALOGS
		{ 
			get 
			{ 
				return "android.intent.action.CLOSE_SYSTEM_DIALOGS"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_INSTALL
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_INSTALL"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_ADDED
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_ADDED"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_REPLACED
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_REPLACED"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_REMOVED
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_REMOVED"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_RESTARTED
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_RESTARTED"; 
			} 
		} 
		public static java.lang.String ACTION_PACKAGE_DATA_CLEARED
		{ 
			get 
			{ 
				return "android.intent.action.PACKAGE_DATA_CLEARED"; 
			} 
		} 
		public static java.lang.String ACTION_UID_REMOVED
		{ 
			get 
			{ 
				return "android.intent.action.UID_REMOVED"; 
			} 
		} 
		public static java.lang.String ACTION_WALLPAPER_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.WALLPAPER_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_CONFIGURATION_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.CONFIGURATION_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_LOCALE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.LOCALE_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_BATTERY_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.BATTERY_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_BATTERY_LOW
		{ 
			get 
			{ 
				return "android.intent.action.BATTERY_LOW"; 
			} 
		} 
		public static java.lang.String ACTION_BATTERY_OKAY
		{ 
			get 
			{ 
				return "android.intent.action.BATTERY_OKAY"; 
			} 
		} 
		public static java.lang.String ACTION_POWER_CONNECTED
		{ 
			get 
			{ 
				return "android.intent.action.ACTION_POWER_CONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_POWER_DISCONNECTED
		{ 
			get 
			{ 
				return "android.intent.action.ACTION_POWER_DISCONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_SHUTDOWN
		{ 
			get 
			{ 
				return "android.intent.action.ACTION_SHUTDOWN"; 
			} 
		} 
		public static java.lang.String ACTION_DEVICE_STORAGE_LOW
		{ 
			get 
			{ 
				return "android.intent.action.DEVICE_STORAGE_LOW"; 
			} 
		} 
		public static java.lang.String ACTION_DEVICE_STORAGE_OK
		{ 
			get 
			{ 
				return "android.intent.action.DEVICE_STORAGE_OK"; 
			} 
		} 
		public static java.lang.String ACTION_MANAGE_PACKAGE_STORAGE
		{ 
			get 
			{ 
				return "android.intent.action.MANAGE_PACKAGE_STORAGE"; 
			} 
		} 
		public static java.lang.String ACTION_UMS_CONNECTED
		{ 
			get 
			{ 
				return "android.intent.action.UMS_CONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_UMS_DISCONNECTED
		{ 
			get 
			{ 
				return "android.intent.action.UMS_DISCONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_REMOVED
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_REMOVED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_UNMOUNTED
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_UNMOUNTED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_CHECKING
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_CHECKING"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_NOFS
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_NOFS"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_MOUNTED
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_MOUNTED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_SHARED
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_SHARED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_BAD_REMOVAL
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_BAD_REMOVAL"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_UNMOUNTABLE
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_UNMOUNTABLE"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_EJECT
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_EJECT"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_SCANNER_STARTED
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_SCANNER_STARTED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_SCANNER_FINISHED
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_SCANNER_FINISHED"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_SCANNER_SCAN_FILE
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_SCANNER_SCAN_FILE"; 
			} 
		} 
		public static java.lang.String ACTION_MEDIA_BUTTON
		{ 
			get 
			{ 
				return "android.intent.action.MEDIA_BUTTON"; 
			} 
		} 
		public static java.lang.String ACTION_CAMERA_BUTTON
		{ 
			get 
			{ 
				return "android.intent.action.CAMERA_BUTTON"; 
			} 
		} 
		public static java.lang.String ACTION_GTALK_SERVICE_CONNECTED
		{ 
			get 
			{ 
				return "android.intent.action.GTALK_CONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_GTALK_SERVICE_DISCONNECTED
		{ 
			get 
			{ 
				return "android.intent.action.GTALK_DISCONNECTED"; 
			} 
		} 
		public static java.lang.String ACTION_INPUT_METHOD_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.INPUT_METHOD_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_AIRPLANE_MODE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.AIRPLANE_MODE"; 
			} 
		} 
		public static java.lang.String ACTION_PROVIDER_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.PROVIDER_CHANGED"; 
			} 
		} 
		public static java.lang.String ACTION_HEADSET_PLUG
		{ 
			get 
			{ 
				return "android.intent.action.HEADSET_PLUG"; 
			} 
		} 
		public static java.lang.String ACTION_NEW_OUTGOING_CALL
		{ 
			get 
			{ 
				return "android.intent.action.NEW_OUTGOING_CALL"; 
			} 
		} 
		public static java.lang.String ACTION_REBOOT
		{ 
			get 
			{ 
				return "android.intent.action.REBOOT"; 
			} 
		} 
		public static java.lang.String ACTION_DOCK_EVENT
		{ 
			get 
			{ 
				return "android.intent.action.DOCK_EVENT"; 
			} 
		} 
		public static java.lang.String CATEGORY_DEFAULT
		{ 
			get 
			{ 
				return "android.intent.category.DEFAULT"; 
			} 
		} 
		public static java.lang.String CATEGORY_BROWSABLE
		{ 
			get 
			{ 
				return "android.intent.category.BROWSABLE"; 
			} 
		} 
		public static java.lang.String CATEGORY_ALTERNATIVE
		{ 
			get 
			{ 
				return "android.intent.category.ALTERNATIVE"; 
			} 
		} 
		public static java.lang.String CATEGORY_SELECTED_ALTERNATIVE
		{ 
			get 
			{ 
				return "android.intent.category.SELECTED_ALTERNATIVE"; 
			} 
		} 
		public static java.lang.String CATEGORY_TAB
		{ 
			get 
			{ 
				return "android.intent.category.TAB"; 
			} 
		} 
		public static java.lang.String CATEGORY_LAUNCHER
		{ 
			get 
			{ 
				return "android.intent.category.LAUNCHER"; 
			} 
		} 
		public static java.lang.String CATEGORY_INFO
		{ 
			get 
			{ 
				return "android.intent.category.INFO"; 
			} 
		} 
		public static java.lang.String CATEGORY_HOME
		{ 
			get 
			{ 
				return "android.intent.category.HOME"; 
			} 
		} 
		public static java.lang.String CATEGORY_PREFERENCE
		{ 
			get 
			{ 
				return "android.intent.category.PREFERENCE"; 
			} 
		} 
		public static java.lang.String CATEGORY_DEVELOPMENT_PREFERENCE
		{ 
			get 
			{ 
				return "android.intent.category.DEVELOPMENT_PREFERENCE"; 
			} 
		} 
		public static java.lang.String CATEGORY_EMBED
		{ 
			get 
			{ 
				return "android.intent.category.EMBED"; 
			} 
		} 
		public static java.lang.String CATEGORY_MONKEY
		{ 
			get 
			{ 
				return "android.intent.category.MONKEY"; 
			} 
		} 
		public static java.lang.String CATEGORY_TEST
		{ 
			get 
			{ 
				return "android.intent.category.TEST"; 
			} 
		} 
		public static java.lang.String CATEGORY_UNIT_TEST
		{ 
			get 
			{ 
				return "android.intent.category.UNIT_TEST"; 
			} 
		} 
		public static java.lang.String CATEGORY_SAMPLE_CODE
		{ 
			get 
			{ 
				return "android.intent.category.SAMPLE_CODE"; 
			} 
		} 
		public static java.lang.String CATEGORY_OPENABLE
		{ 
			get 
			{ 
				return "android.intent.category.OPENABLE"; 
			} 
		} 
		public static java.lang.String CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST
		{ 
			get 
			{ 
				return "android.intent.category.FRAMEWORK_INSTRUMENTATION_TEST"; 
			} 
		} 
		public static java.lang.String CATEGORY_CAR_DOCK
		{ 
			get 
			{ 
				return "android.intent.category.CAR_DOCK"; 
			} 
		} 
		public static java.lang.String CATEGORY_DESK_DOCK
		{ 
			get 
			{ 
				return "android.intent.category.DESK_DOCK"; 
			} 
		} 
		public static java.lang.String EXTRA_TEMPLATE
		{ 
			get 
			{ 
				return "android.intent.extra.TEMPLATE"; 
			} 
		} 
		public static java.lang.String EXTRA_TEXT
		{ 
			get 
			{ 
				return "android.intent.extra.TEXT"; 
			} 
		} 
		public static java.lang.String EXTRA_STREAM
		{ 
			get 
			{ 
				return "android.intent.extra.STREAM"; 
			} 
		} 
		public static java.lang.String EXTRA_EMAIL
		{ 
			get 
			{ 
				return "android.intent.extra.EMAIL"; 
			} 
		} 
		public static java.lang.String EXTRA_CC
		{ 
			get 
			{ 
				return "android.intent.extra.CC"; 
			} 
		} 
		public static java.lang.String EXTRA_BCC
		{ 
			get 
			{ 
				return "android.intent.extra.BCC"; 
			} 
		} 
		public static java.lang.String EXTRA_SUBJECT
		{ 
			get 
			{ 
				return "android.intent.extra.SUBJECT"; 
			} 
		} 
		public static java.lang.String EXTRA_INTENT
		{ 
			get 
			{ 
				return "android.intent.extra.INTENT"; 
			} 
		} 
		public static java.lang.String EXTRA_TITLE
		{ 
			get 
			{ 
				return "android.intent.extra.TITLE"; 
			} 
		} 
		public static java.lang.String EXTRA_INITIAL_INTENTS
		{ 
			get 
			{ 
				return "android.intent.extra.INITIAL_INTENTS"; 
			} 
		} 
		public static java.lang.String EXTRA_KEY_EVENT
		{ 
			get 
			{ 
				return "android.intent.extra.KEY_EVENT"; 
			} 
		} 
		public static java.lang.String EXTRA_DONT_KILL_APP
		{ 
			get 
			{ 
				return "android.intent.extra.DONT_KILL_APP"; 
			} 
		} 
		public static java.lang.String EXTRA_PHONE_NUMBER
		{ 
			get 
			{ 
				return "android.intent.extra.PHONE_NUMBER"; 
			} 
		} 
		public static java.lang.String EXTRA_UID
		{ 
			get 
			{ 
				return "android.intent.extra.UID"; 
			} 
		} 
		public static java.lang.String EXTRA_DATA_REMOVED
		{ 
			get 
			{ 
				return "android.intent.extra.DATA_REMOVED"; 
			} 
		} 
		public static java.lang.String EXTRA_REPLACING
		{ 
			get 
			{ 
				return "android.intent.extra.REPLACING"; 
			} 
		} 
		public static java.lang.String EXTRA_ALARM_COUNT
		{ 
			get 
			{ 
				return "android.intent.extra.ALARM_COUNT"; 
			} 
		} 
		public static java.lang.String EXTRA_DOCK_STATE
		{ 
			get 
			{ 
				return "android.intent.extra.DOCK_STATE"; 
			} 
		} 
		public static int EXTRA_DOCK_STATE_UNDOCKED
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int EXTRA_DOCK_STATE_DESK
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int EXTRA_DOCK_STATE_CAR
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static java.lang.String METADATA_DOCK_HOME
		{ 
			get 
			{ 
				return "android.dock_home"; 
			} 
		} 
		public static java.lang.String EXTRA_REMOTE_INTENT_TOKEN
		{ 
			get 
			{ 
				return "android.intent.extra.remote_intent_token"; 
			} 
		} 
		public static java.lang.String EXTRA_CHANGED_COMPONENT_NAME
		{ 
			get 
			{ 
				return "android.intent.extra.changed_component_name"; 
			} 
		} 
		public static java.lang.String EXTRA_CHANGED_COMPONENT_NAME_LIST
		{ 
			get 
			{ 
				return "android.intent.extra.changed_component_name_list"; 
			} 
		} 
		public static int FLAG_GRANT_READ_URI_PERMISSION
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FLAG_GRANT_WRITE_URI_PERMISSION
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int FLAG_FROM_BACKGROUND
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int FLAG_DEBUG_LOG_RESOLUTION
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int FLAG_ACTIVITY_NO_HISTORY
		{ 
			get 
			{ 
				return 1073741824; 
			} 
		} 
		public static int FLAG_ACTIVITY_SINGLE_TOP
		{ 
			get 
			{ 
				return 536870912; 
			} 
		} 
		public static int FLAG_ACTIVITY_NEW_TASK
		{ 
			get 
			{ 
				return 268435456; 
			} 
		} 
		public static int FLAG_ACTIVITY_MULTIPLE_TASK
		{ 
			get 
			{ 
				return 134217728; 
			} 
		} 
		public static int FLAG_ACTIVITY_CLEAR_TOP
		{ 
			get 
			{ 
				return 67108864; 
			} 
		} 
		public static int FLAG_ACTIVITY_FORWARD_RESULT
		{ 
			get 
			{ 
				return 33554432; 
			} 
		} 
		public static int FLAG_ACTIVITY_PREVIOUS_IS_TOP
		{ 
			get 
			{ 
				return 16777216; 
			} 
		} 
		public static int FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS
		{ 
			get 
			{ 
				return 8388608; 
			} 
		} 
		public static int FLAG_ACTIVITY_BROUGHT_TO_FRONT
		{ 
			get 
			{ 
				return 4194304; 
			} 
		} 
		public static int FLAG_ACTIVITY_RESET_TASK_IF_NEEDED
		{ 
			get 
			{ 
				return 2097152; 
			} 
		} 
		public static int FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY
		{ 
			get 
			{ 
				return 1048576; 
			} 
		} 
		public static int FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET
		{ 
			get 
			{ 
				return 524288; 
			} 
		} 
		public static int FLAG_ACTIVITY_NO_USER_ACTION
		{ 
			get 
			{ 
				return 262144; 
			} 
		} 
		public static int FLAG_ACTIVITY_REORDER_TO_FRONT
		{ 
			get 
			{ 
				return 131072; 
			} 
		} 
		public static int FLAG_ACTIVITY_NO_ANIMATION
		{ 
			get 
			{ 
				return 65536; 
			} 
		} 
		public static int FLAG_RECEIVER_REGISTERED_ONLY
		{ 
			get 
			{ 
				return 1073741824; 
			} 
		} 
		public static int URI_INTENT_SCHEME
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FILL_IN_ACTION
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int FILL_IN_DATA
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int FILL_IN_CATEGORIES
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int FILL_IN_COMPONENT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int FILL_IN_PACKAGE
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int FILL_IN_SOURCE_BOUNDS
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1382; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.Intent.staticClass = @__class; 
			global::android.content.Intent._clone1269 = @__env.GetMethodID(global::android.content.Intent.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::android.content.Intent._toString1270 = @__env.GetMethodID(global::android.content.Intent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.Intent._getPackage1271 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getPackage", "()Ljava/lang/String;"); 
			global::android.content.Intent._getType1272 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getType", "()Ljava/lang/String;"); 
			global::android.content.Intent._toURI1273 = @__env.GetMethodID(global::android.content.Intent.staticClass, "toURI", "()Ljava/lang/String;"); 
			global::android.content.Intent._getScheme1274 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getScheme", "()Ljava/lang/String;"); 
			global::android.content.Intent._getData1275 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getData", "()Landroid/net/Uri;"); 
			global::android.content.Intent._getComponent1276 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getComponent", "()Landroid/content/ComponentName;"); 
			global::android.content.Intent._setClassName1277 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setClassName", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._setClassName1278 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setClassName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._writeToParcel1279 = @__env.GetMethodID(global::android.content.Intent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.Intent._describeContents1280 = @__env.GetMethodID(global::android.content.Intent.staticClass, "describeContents", "()I"); 
			global::android.content.Intent._createChooser1281 = @__env.GetStaticMethodID(global::android.content.Intent.staticClass, "createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;"); 
			global::android.content.Intent._cloneFilter1282 = @__env.GetMethodID(global::android.content.Intent.staticClass, "cloneFilter", "()Landroid/content/Intent;"); 
			global::android.content.Intent._getIntent1283 = @__env.GetStaticMethodID(global::android.content.Intent.staticClass, "getIntent", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._parseUri1284 = @__env.GetStaticMethodID(global::android.content.Intent.staticClass, "parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;"); 
			global::android.content.Intent._getIntentOld1285 = @__env.GetStaticMethodID(global::android.content.Intent.staticClass, "getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._getAction1286 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getAction", "()Ljava/lang/String;"); 
			global::android.content.Intent._getDataString1287 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getDataString", "()Ljava/lang/String;"); 
			global::android.content.Intent._resolveType1288 = @__env.GetMethodID(global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/Context;)Ljava/lang/String;"); 
			global::android.content.Intent._resolveType1289 = @__env.GetMethodID(global::android.content.Intent.staticClass, "resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;"); 
			global::android.content.Intent._resolveTypeIfNeeded1290 = @__env.GetMethodID(global::android.content.Intent.staticClass, "resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;"); 
			global::android.content.Intent._hasCategory1291 = @__env.GetMethodID(global::android.content.Intent.staticClass, "hasCategory", "(Ljava/lang/String;)Z"); 
			global::android.content.Intent._getCategories1292 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getCategories", "()Ljava/util/Set;"); 
			global::android.content.Intent._setExtrasClassLoader1293 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V"); 
			global::android.content.Intent._hasExtra1294 = @__env.GetMethodID(global::android.content.Intent.staticClass, "hasExtra", "(Ljava/lang/String;)Z"); 
			global::android.content.Intent._hasFileDescriptors1295 = @__env.GetMethodID(global::android.content.Intent.staticClass, "hasFileDescriptors", "()Z"); 
			global::android.content.Intent._getBooleanExtra1296 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getBooleanExtra", "(Ljava/lang/String;Z)Z"); 
			global::android.content.Intent._getByteExtra1297 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getByteExtra", "(Ljava/lang/String;B)B"); 
			global::android.content.Intent._getShortExtra1298 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getShortExtra", "(Ljava/lang/String;S)S"); 
			global::android.content.Intent._getCharExtra1299 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getCharExtra", "(Ljava/lang/String;C)C"); 
			global::android.content.Intent._getIntExtra1300 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getIntExtra", "(Ljava/lang/String;I)I"); 
			global::android.content.Intent._getLongExtra1301 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getLongExtra", "(Ljava/lang/String;J)J"); 
			global::android.content.Intent._getFloatExtra1302 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getFloatExtra", "(Ljava/lang/String;F)F"); 
			global::android.content.Intent._getDoubleExtra1303 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getDoubleExtra", "(Ljava/lang/String;D)D"); 
			global::android.content.Intent._getStringExtra1304 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.Intent._getCharSequenceExtra1305 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;"); 
			global::android.content.Intent._getParcelableExtra1306 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;"); 
			global::android.content.Intent._getParcelableArrayExtra1307 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;"); 
			global::android.content.Intent._getParcelableArrayListExtra1308 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.content.Intent._getSerializableExtra1309 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;"); 
			global::android.content.Intent._getIntegerArrayListExtra1310 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.content.Intent._getStringArrayListExtra1311 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.content.Intent._getBooleanArrayExtra1312 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getBooleanArrayExtra", "(Ljava/lang/String;)[Z"); 
			global::android.content.Intent._getByteArrayExtra1313 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getByteArrayExtra", "(Ljava/lang/String;)[B"); 
			global::android.content.Intent._getShortArrayExtra1314 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getShortArrayExtra", "(Ljava/lang/String;)[S"); 
			global::android.content.Intent._getCharArrayExtra1315 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getCharArrayExtra", "(Ljava/lang/String;)[C"); 
			global::android.content.Intent._getIntArrayExtra1316 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getIntArrayExtra", "(Ljava/lang/String;)[I"); 
			global::android.content.Intent._getLongArrayExtra1317 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getLongArrayExtra", "(Ljava/lang/String;)[J"); 
			global::android.content.Intent._getFloatArrayExtra1318 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getFloatArrayExtra", "(Ljava/lang/String;)[F"); 
			global::android.content.Intent._getDoubleArrayExtra1319 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getDoubleArrayExtra", "(Ljava/lang/String;)[D"); 
			global::android.content.Intent._getStringArrayExtra1320 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;"); 
			global::android.content.Intent._getBundleExtra1321 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;"); 
			global::android.content.Intent._getExtras1322 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.content.Intent._getFlags1323 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getFlags", "()I"); 
			global::android.content.Intent._getSourceBounds1324 = @__env.GetMethodID(global::android.content.Intent.staticClass, "getSourceBounds", "()Landroid/graphics/Rect;"); 
			global::android.content.Intent._resolveActivity1325 = @__env.GetMethodID(global::android.content.Intent.staticClass, "resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;"); 
			global::android.content.Intent._resolveActivityInfo1326 = @__env.GetMethodID(global::android.content.Intent.staticClass, "resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;"); 
			global::android.content.Intent._setAction1327 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setAction", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._setData1328 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setData", "(Landroid/net/Uri;)Landroid/content/Intent;"); 
			global::android.content.Intent._setType1329 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setType", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._setDataAndType1330 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._addCategory1331 = @__env.GetMethodID(global::android.content.Intent.staticClass, "addCategory", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._removeCategory1332 = @__env.GetMethodID(global::android.content.Intent.staticClass, "removeCategory", "(Ljava/lang/String;)V"); 
			global::android.content.Intent._putExtra1333 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1334 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Z)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1335 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1336 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;C)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1337 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;S)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1338 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;I)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1339 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;J)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1340 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;F)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1341 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;D)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1342 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1343 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/lang/CharSequence;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1344 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Parcelable;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1345 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1346 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1347 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Z)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1348 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[S)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1349 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[C)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1350 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[I)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1351 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[J)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1352 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[F)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1353 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[D)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1354 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtra1355 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtra", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;"); 
			global::android.content.Intent._putParcelableArrayListExtra1356 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;"); 
			global::android.content.Intent._putIntegerArrayListExtra1357 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;"); 
			global::android.content.Intent._putStringArrayListExtra1358 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtras1359 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;"); 
			global::android.content.Intent._putExtras1360 = @__env.GetMethodID(global::android.content.Intent.staticClass, "putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;"); 
			global::android.content.Intent._replaceExtras1361 = @__env.GetMethodID(global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;"); 
			global::android.content.Intent._replaceExtras1362 = @__env.GetMethodID(global::android.content.Intent.staticClass, "replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;"); 
			global::android.content.Intent._removeExtra1363 = @__env.GetMethodID(global::android.content.Intent.staticClass, "removeExtra", "(Ljava/lang/String;)V"); 
			global::android.content.Intent._setFlags1364 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setFlags", "(I)Landroid/content/Intent;"); 
			global::android.content.Intent._addFlags1365 = @__env.GetMethodID(global::android.content.Intent.staticClass, "addFlags", "(I)Landroid/content/Intent;"); 
			global::android.content.Intent._setPackage1366 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setPackage", "(Ljava/lang/String;)Landroid/content/Intent;"); 
			global::android.content.Intent._setComponent1367 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;"); 
			global::android.content.Intent._setClass1368 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;"); 
			global::android.content.Intent._setSourceBounds1369 = @__env.GetMethodID(global::android.content.Intent.staticClass, "setSourceBounds", "(Landroid/graphics/Rect;)V"); 
			global::android.content.Intent._fillIn1370 = @__env.GetMethodID(global::android.content.Intent.staticClass, "fillIn", "(Landroid/content/Intent;I)I"); 
			global::android.content.Intent._filterEquals1371 = @__env.GetMethodID(global::android.content.Intent.staticClass, "filterEquals", "(Landroid/content/Intent;)Z"); 
			global::android.content.Intent._filterHashCode1372 = @__env.GetMethodID(global::android.content.Intent.staticClass, "filterHashCode", "()I"); 
			global::android.content.Intent._toUri1373 = @__env.GetMethodID(global::android.content.Intent.staticClass, "toUri", "(I)Ljava/lang/String;"); 
			global::android.content.Intent._readFromParcel1374 = @__env.GetMethodID(global::android.content.Intent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.content.Intent._parseIntent1375 = @__env.GetStaticMethodID(global::android.content.Intent.staticClass, "parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/content/Intent;"); 
			global::android.content.Intent._Intent1376 = @__env.GetMethodID(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;)V"); 
			global::android.content.Intent._Intent1377 = @__env.GetMethodID(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Intent;)V"); 
			global::android.content.Intent._Intent1378 = @__env.GetMethodID(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.content.Intent._Intent1379 = @__env.GetMethodID(global::android.content.Intent.staticClass, "<init>", "()V"); 
			global::android.content.Intent._Intent1380 = @__env.GetMethodID(global::android.content.Intent.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V"); 
			global::android.content.Intent._Intent1381 = @__env.GetMethodID(global::android.content.Intent.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V"); 
		} 
	} 
} 

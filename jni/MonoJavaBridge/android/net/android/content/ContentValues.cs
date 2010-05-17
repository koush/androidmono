namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ContentValues : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentValues() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentValues), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ContentValues(@__env); 
			} 
		} 
		internal ContentValues(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get1075; 
		public java.lang.Object get(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get1075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _get1075, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1076; 
		public void put(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1077; 
		public void put(java.lang.String arg0, java.lang.Byte arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1078; 
		public void put(java.lang.String arg0, java.lang.Short arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1079; 
		public void put(java.lang.String arg0, java.lang.Integer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1080; 
		public void put(java.lang.String arg0, java.lang.Long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1081; 
		public void put(java.lang.String arg0, java.lang.Float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1082; 
		public void put(java.lang.String arg0, java.lang.Double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1083; 
		public void put(java.lang.String arg0, java.lang.Boolean arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1084; 
		public void put(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _put1084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _put1084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1085; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallIntMethod(this, _hashCode1085); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentValues.staticClass, _hashCode1085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals1086; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallBooleanMethod(this, _equals1086, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentValues.staticClass, _equals1086, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear1087; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _clear1087); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _clear1087); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1088; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1088)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _toString1088)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size1089; 
		public int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallIntMethod(this, _size1089); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentValues.staticClass, _size1089); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putAll1090; 
		public void putAll(android.content.ContentValues arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _putAll1090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _putAll1090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove1091; 
		public void remove(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _remove1091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _remove1091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey1092; 
		public bool containsKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallBooleanMethod(this, _containsKey1092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ContentValues.staticClass, _containsKey1092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsString1093; 
		public java.lang.String getAsString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAsString1093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsString1093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putNull1094; 
		public void putNull(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _putNull1094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _putNull1094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1095; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, _writeToParcel1095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentValues.staticClass, _writeToParcel1095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1096; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallIntMethod(this, _describeContents1096); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentValues.staticClass, _describeContents1096); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsLong1097; 
		public java.lang.Long getAsLong(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Long>(@__env, @__env.CallObjectMethodPtr(this, _getAsLong1097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Long>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsLong1097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsInteger1098; 
		public java.lang.Integer getAsInteger(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, _getAsInteger1098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsInteger1098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsShort1099; 
		public java.lang.Short getAsShort(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Short>(@__env, @__env.CallObjectMethodPtr(this, _getAsShort1099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Short>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsShort1099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsByte1100; 
		public java.lang.Byte getAsByte(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallObjectMethodPtr(this, _getAsByte1100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsByte1100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsDouble1101; 
		public java.lang.Double getAsDouble(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Double>(@__env, @__env.CallObjectMethodPtr(this, _getAsDouble1101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Double>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsDouble1101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsFloat1102; 
		public java.lang.Float getAsFloat(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Float>(@__env, @__env.CallObjectMethodPtr(this, _getAsFloat1102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Float>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsFloat1102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsBoolean1103; 
		public java.lang.Boolean getAsBoolean(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Boolean>(@__env, @__env.CallObjectMethodPtr(this, _getAsBoolean1103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Boolean>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsBoolean1103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsByteArray1104; 
		public byte[] getAsByteArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.ContentValues)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAsByteArray1104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _getAsByteArray1104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueSet1105; 
		public java.util.Set valueSet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _valueSet1105)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentValues.staticClass, _valueSet1105)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1106; 
		public ContentValues()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentValues.staticClass, _ContentValues1106, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1107; 
		public ContentValues(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentValues.staticClass, _ContentValues1107, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1108; 
		public ContentValues(android.content.ContentValues arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentValues.staticClass, _ContentValues1108, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static java.lang.String TAG
		{ 
			get 
			{ 
				return "ContentValues"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1109; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentValues.staticClass = @__class; 
			global::android.content.ContentValues._get1075 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.content.ContentValues._put1076 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.ContentValues._put1077 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V"); 
			global::android.content.ContentValues._put1078 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V"); 
			global::android.content.ContentValues._put1079 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V"); 
			global::android.content.ContentValues._put1080 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V"); 
			global::android.content.ContentValues._put1081 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V"); 
			global::android.content.ContentValues._put1082 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V"); 
			global::android.content.ContentValues._put1083 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V"); 
			global::android.content.ContentValues._put1084 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V"); 
			global::android.content.ContentValues._hashCode1085 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "hashCode", "()I"); 
			global::android.content.ContentValues._equals1086 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.ContentValues._clear1087 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "clear", "()V"); 
			global::android.content.ContentValues._toString1088 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.ContentValues._size1089 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "size", "()I"); 
			global::android.content.ContentValues._putAll1090 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V"); 
			global::android.content.ContentValues._remove1091 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V"); 
			global::android.content.ContentValues._containsKey1092 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z"); 
			global::android.content.ContentValues._getAsString1093 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.ContentValues._putNull1094 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V"); 
			global::android.content.ContentValues._writeToParcel1095 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.ContentValues._describeContents1096 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "describeContents", "()I"); 
			global::android.content.ContentValues._getAsLong1097 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;"); 
			global::android.content.ContentValues._getAsInteger1098 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;"); 
			global::android.content.ContentValues._getAsShort1099 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;"); 
			global::android.content.ContentValues._getAsByte1100 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;"); 
			global::android.content.ContentValues._getAsDouble1101 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;"); 
			global::android.content.ContentValues._getAsFloat1102 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;"); 
			global::android.content.ContentValues._getAsBoolean1103 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;"); 
			global::android.content.ContentValues._getAsByteArray1104 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B"); 
			global::android.content.ContentValues._valueSet1105 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;"); 
			global::android.content.ContentValues._ContentValues1106 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "()V"); 
			global::android.content.ContentValues._ContentValues1107 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "(I)V"); 
			global::android.content.ContentValues._ContentValues1108 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V"); 
		} 
	} 
} 

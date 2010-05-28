namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ContentValues : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentValues() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContentValues), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _get1090; 
		public global::java.lang.Object get(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._get1090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._get1090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1091; 
		public void put(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1092; 
		public void put(java.lang.String arg0, java.lang.Byte arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1093; 
		public void put(java.lang.String arg0, java.lang.Short arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1094; 
		public void put(java.lang.String arg0, java.lang.Integer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1095; 
		public void put(java.lang.String arg0, java.lang.Long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1096; 
		public void put(java.lang.String arg0, java.lang.Float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1097; 
		public void put(java.lang.String arg0, java.lang.Double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1098; 
		public void put(java.lang.String arg0, java.lang.Boolean arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put1099; 
		public void put(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1100; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallIntMethod(this, global::android.content.ContentValues._hashCode1100); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._hashCode1100); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals1101; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallBooleanMethod(this, global::android.content.ContentValues._equals1101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._equals1101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear1102; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._clear1102); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._clear1102); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1103; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._toString1103)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._toString1103)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size1104; 
		public int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallIntMethod(this, global::android.content.ContentValues._size1104); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._size1104); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putAll1105; 
		public void putAll(android.content.ContentValues arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._putAll1105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putAll1105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove1106; 
		public void remove(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._remove1106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._remove1106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey1107; 
		public bool containsKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallBooleanMethod(this, global::android.content.ContentValues._containsKey1107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._containsKey1107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsString1108; 
		public global::java.lang.String getAsString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsString1108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsString1108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putNull1109; 
		public void putNull(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._putNull1109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putNull1109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1110; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				@__env.CallVoidMethod(this, global::android.content.ContentValues._writeToParcel1110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._writeToParcel1110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1111; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return @__env.CallIntMethod(this, global::android.content.ContentValues._describeContents1111); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._describeContents1111); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsLong1112; 
		public global::java.lang.Long getAsLong(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Long>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsLong1112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Long>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsLong1112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsInteger1113; 
		public global::java.lang.Integer getAsInteger(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsInteger1113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsInteger1113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsShort1114; 
		public global::java.lang.Short getAsShort(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Short>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsShort1114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Short>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsShort1114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsByte1115; 
		public global::java.lang.Byte getAsByte(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsByte1115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByte1115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsDouble1116; 
		public global::java.lang.Double getAsDouble(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Double>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsDouble1116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Double>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsDouble1116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsFloat1117; 
		public global::java.lang.Float getAsFloat(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Float>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsFloat1117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Float>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsFloat1117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsBoolean1118; 
		public global::java.lang.Boolean getAsBoolean(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Boolean>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsBoolean1118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Boolean>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsBoolean1118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAsByteArray1119; 
		public byte[] getAsByteArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.content.ContentValues)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsByteArray1119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByteArray1119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueSet1120; 
		public global::java.util.Set valueSet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentValues)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._valueSet1120)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._valueSet1120)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1121; 
		public ContentValues()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1121, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1122; 
		public ContentValues(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1122, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1123; 
		public ContentValues(android.content.ContentValues arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1123, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static global::java.lang.String TAG
		{ 
			get 
			{ 
				return "ContentValues"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1124; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentValues.staticClass = @__class; 
			global::android.content.ContentValues._get1090 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.content.ContentValues._put1091 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.ContentValues._put1092 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V"); 
			global::android.content.ContentValues._put1093 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V"); 
			global::android.content.ContentValues._put1094 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V"); 
			global::android.content.ContentValues._put1095 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V"); 
			global::android.content.ContentValues._put1096 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V"); 
			global::android.content.ContentValues._put1097 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V"); 
			global::android.content.ContentValues._put1098 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V"); 
			global::android.content.ContentValues._put1099 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V"); 
			global::android.content.ContentValues._hashCode1100 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "hashCode", "()I"); 
			global::android.content.ContentValues._equals1101 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.ContentValues._clear1102 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "clear", "()V"); 
			global::android.content.ContentValues._toString1103 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.ContentValues._size1104 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "size", "()I"); 
			global::android.content.ContentValues._putAll1105 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V"); 
			global::android.content.ContentValues._remove1106 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V"); 
			global::android.content.ContentValues._containsKey1107 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z"); 
			global::android.content.ContentValues._getAsString1108 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.content.ContentValues._putNull1109 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V"); 
			global::android.content.ContentValues._writeToParcel1110 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.ContentValues._describeContents1111 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "describeContents", "()I"); 
			global::android.content.ContentValues._getAsLong1112 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;"); 
			global::android.content.ContentValues._getAsInteger1113 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;"); 
			global::android.content.ContentValues._getAsShort1114 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;"); 
			global::android.content.ContentValues._getAsByte1115 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;"); 
			global::android.content.ContentValues._getAsDouble1116 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;"); 
			global::android.content.ContentValues._getAsFloat1117 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;"); 
			global::android.content.ContentValues._getAsBoolean1118 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;"); 
			global::android.content.ContentValues._getAsByteArray1119 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B"); 
			global::android.content.ContentValues._valueSet1120 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;"); 
			global::android.content.ContentValues._ContentValues1121 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "()V"); 
			global::android.content.ContentValues._ContentValues1122 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "(I)V"); 
			global::android.content.ContentValues._ContentValues1123 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V"); 
		} 
	} 
} 

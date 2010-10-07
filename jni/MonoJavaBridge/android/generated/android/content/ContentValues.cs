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
		internal static global::net.sf.jni4net.jni.MethodId _get1227;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._get1227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._get1227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1228;
		public void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1229;
		public void put(java.lang.String arg0, java.lang.Byte arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1230;
		public void put(java.lang.String arg0, java.lang.Short arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1231;
		public void put(java.lang.String arg0, java.lang.Integer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1232;
		public void put(java.lang.String arg0, java.lang.Long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1233;
		public void put(java.lang.String arg0, java.lang.Boolean arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1234;
		public void put(java.lang.String arg0, byte[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1235;
		public void put(java.lang.String arg0, java.lang.Float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put1236;
		public void put(java.lang.String arg0, java.lang.Double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._put1236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1237;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentValues._equals1237, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._equals1237, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1238;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._toString1238));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._toString1238));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1239;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentValues._hashCode1239);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._hashCode1239);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear1240;
		public void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._clear1240);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._clear1240);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size1241;
		public int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentValues._size1241);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._size1241);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putAll1242;
		public void putAll(android.content.ContentValues arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._putAll1242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putAll1242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove1243;
		public void remove(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._remove1243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._remove1243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsKey1244;
		public bool containsKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.ContentValues._containsKey1244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._containsKey1244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsString1245;
		public global::java.lang.String getAsString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsString1245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsString1245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putNull1246;
		public void putNull(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._putNull1246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putNull1246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1247;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentValues._writeToParcel1247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._writeToParcel1247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1248;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentValues._describeContents1248);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._describeContents1248);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsLong1249;
		public global::java.lang.Long getAsLong(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Long>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsLong1249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Long>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsLong1249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsInteger1250;
		public global::java.lang.Integer getAsInteger(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsInteger1250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Integer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsInteger1250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsShort1251;
		public global::java.lang.Short getAsShort(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Short>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsShort1251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Short>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsShort1251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsByte1252;
		public global::java.lang.Byte getAsByte(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsByte1252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByte1252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsDouble1253;
		public global::java.lang.Double getAsDouble(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Double>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsDouble1253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Double>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsDouble1253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsFloat1254;
		public global::java.lang.Float getAsFloat(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Float>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsFloat1254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Float>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsFloat1254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsBoolean1255;
		public global::java.lang.Boolean getAsBoolean(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Boolean>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsBoolean1255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Boolean>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsBoolean1255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAsByteArray1256;
		public byte[] getAsByteArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._getAsByteArray1256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByteArray1256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueSet1257;
		public global::java.util.Set valueSet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentValues._valueSet1257));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._valueSet1257));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1258;
		public ContentValues()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1258, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1259;
		public ContentValues(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1259, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentValues1260;
		public ContentValues(android.content.ContentValues arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1260, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static global::java.lang.String TAG
		{
			get
			{
				return "ContentValues";
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1261;
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
			global::android.content.ContentValues._get1227 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContentValues._put1228 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContentValues._put1229 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V");
			global::android.content.ContentValues._put1230 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V");
			global::android.content.ContentValues._put1231 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V");
			global::android.content.ContentValues._put1232 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V");
			global::android.content.ContentValues._put1233 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::android.content.ContentValues._put1234 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V");
			global::android.content.ContentValues._put1235 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V");
			global::android.content.ContentValues._put1236 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V");
			global::android.content.ContentValues._equals1237 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.ContentValues._toString1238 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentValues._hashCode1239 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "hashCode", "()I");
			global::android.content.ContentValues._clear1240 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "clear", "()V");
			global::android.content.ContentValues._size1241 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "size", "()I");
			global::android.content.ContentValues._putAll1242 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V");
			global::android.content.ContentValues._remove1243 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.content.ContentValues._containsKey1244 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.content.ContentValues._getAsString1245 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.ContentValues._putNull1246 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V");
			global::android.content.ContentValues._writeToParcel1247 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentValues._describeContents1248 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "describeContents", "()I");
			global::android.content.ContentValues._getAsLong1249 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::android.content.ContentValues._getAsInteger1250 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::android.content.ContentValues._getAsShort1251 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::android.content.ContentValues._getAsByte1252 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::android.content.ContentValues._getAsDouble1253 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;");
			global::android.content.ContentValues._getAsFloat1254 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;");
			global::android.content.ContentValues._getAsBoolean1255 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::android.content.ContentValues._getAsByteArray1256 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B");
			global::android.content.ContentValues._valueSet1257 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;");
			global::android.content.ContentValues._ContentValues1258 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "()V");
			global::android.content.ContentValues._ContentValues1259 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "(I)V");
			global::android.content.ContentValues._ContentValues1260 = @__env.GetMethodID(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
		}
	}
}

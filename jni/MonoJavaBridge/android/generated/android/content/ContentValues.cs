namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ContentValues : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentValues()
		{
			InitJNI();
		}
		internal ContentValues(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get1251;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._get1251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._get1251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put1252;
		public void put(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1253;
		public void put(java.lang.String arg0, java.lang.Byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1254;
		public void put(java.lang.String arg0, java.lang.Short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1255;
		public void put(java.lang.String arg0, java.lang.Integer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1256;
		public void put(java.lang.String arg0, java.lang.Long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1257;
		public void put(java.lang.String arg0, java.lang.Boolean arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1258;
		public void put(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1259;
		public void put(java.lang.String arg0, java.lang.Float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put1260;
		public void put(java.lang.String arg0, java.lang.Double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._put1260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._put1260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals1261;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentValues._equals1261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._equals1261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1262;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._toString1262)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._toString1262)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1263;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentValues._hashCode1263);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._hashCode1263);
		}
		internal static global::MonoJavaBridge.MethodId _clear1264;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._clear1264);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._clear1264);
		}
		internal static global::MonoJavaBridge.MethodId _size1265;
		public int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentValues._size1265);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._size1265);
		}
		internal static global::MonoJavaBridge.MethodId _putAll1266;
		public void putAll(android.content.ContentValues arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._putAll1266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putAll1266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove1267;
		public void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._remove1267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._remove1267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey1268;
		public bool containsKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ContentValues._containsKey1268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._containsKey1268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAsString1269;
		public global::java.lang.String getAsString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsString1269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsString1269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putNull1270;
		public void putNull(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._putNull1270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._putNull1270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1271;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentValues._writeToParcel1271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._writeToParcel1271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1272;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentValues._describeContents1272);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._describeContents1272);
		}
		internal static global::MonoJavaBridge.MethodId _getAsLong1273;
		public global::java.lang.Long getAsLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsLong1273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsLong1273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getAsInteger1274;
		public global::java.lang.Integer getAsInteger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsInteger1274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsInteger1274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getAsShort1275;
		public global::java.lang.Short getAsShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsShort1275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsShort1275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _getAsByte1276;
		public global::java.lang.Byte getAsByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsByte1276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByte1276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _getAsDouble1277;
		public global::java.lang.Double getAsDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsDouble1277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsDouble1277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _getAsFloat1278;
		public global::java.lang.Float getAsFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsFloat1278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsFloat1278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _getAsBoolean1279;
		public global::java.lang.Boolean getAsBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsBoolean1279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsBoolean1279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _getAsByteArray1280;
		public byte[] getAsByteArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._getAsByteArray1280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._getAsByteArray1280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _valueSet1281;
		public global::java.util.Set valueSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentValues._valueSet1281)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentValues.staticClass, global::android.content.ContentValues._valueSet1281)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues1282;
		public ContentValues()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1282);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues1283;
		public ContentValues(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues1284;
		public ContentValues(android.content.ContentValues arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues1284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TAG
		{
			get
			{
				return "ContentValues";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1285;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentValues"));
			global::android.content.ContentValues._get1251 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.content.ContentValues._put1252 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ContentValues._put1253 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V");
			global::android.content.ContentValues._put1254 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V");
			global::android.content.ContentValues._put1255 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V");
			global::android.content.ContentValues._put1256 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V");
			global::android.content.ContentValues._put1257 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			global::android.content.ContentValues._put1258 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V");
			global::android.content.ContentValues._put1259 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V");
			global::android.content.ContentValues._put1260 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V");
			global::android.content.ContentValues._equals1261 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.ContentValues._toString1262 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentValues._hashCode1263 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "hashCode", "()I");
			global::android.content.ContentValues._clear1264 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "clear", "()V");
			global::android.content.ContentValues._size1265 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "size", "()I");
			global::android.content.ContentValues._putAll1266 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V");
			global::android.content.ContentValues._remove1267 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.content.ContentValues._containsKey1268 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.content.ContentValues._getAsString1269 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.ContentValues._putNull1270 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V");
			global::android.content.ContentValues._writeToParcel1271 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentValues._describeContents1272 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "describeContents", "()I");
			global::android.content.ContentValues._getAsLong1273 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::android.content.ContentValues._getAsInteger1274 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::android.content.ContentValues._getAsShort1275 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::android.content.ContentValues._getAsByte1276 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::android.content.ContentValues._getAsDouble1277 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;");
			global::android.content.ContentValues._getAsFloat1278 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;");
			global::android.content.ContentValues._getAsBoolean1279 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			global::android.content.ContentValues._getAsByteArray1280 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B");
			global::android.content.ContentValues._valueSet1281 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;");
			global::android.content.ContentValues._ContentValues1282 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "()V");
			global::android.content.ContentValues._ContentValues1283 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(I)V");
			global::android.content.ContentValues._ContentValues1284 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
		}
	}
}

namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorWindow : android.database.sqlite.SQLiteClosable, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorWindow()
		{
			InitJNI();
		}
		protected CursorWindow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize2611;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._finalize2611);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._finalize2611);
		}
		internal static global::MonoJavaBridge.MethodId _getShort2612;
		public virtual short getShort(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.CursorWindow._getShort2612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getShort2612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2613;
		public virtual int getInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWindow._getInt2613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getInt2613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2614;
		public virtual long getLong(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.CursorWindow._getLong2614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getLong2614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong2615;
		public virtual bool putLong(long arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._putLong2615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putLong2615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2616;
		public virtual float getFloat(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.CursorWindow._getFloat2616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getFloat2616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2617;
		public virtual double getDouble(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.CursorWindow._getDouble2617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getDouble2617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble2618;
		public virtual bool putDouble(double arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._putDouble2618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putDouble2618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear2619;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._clear2619);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._clear2619);
		}
		internal static global::MonoJavaBridge.MethodId _close2620;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._close2620);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._close2620);
		}
		internal static global::MonoJavaBridge.MethodId _getString2621;
		public virtual global::java.lang.String getString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWindow._getString2621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getString2621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putNull2622;
		public virtual bool putNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._putNull2622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putNull2622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2623;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._writeToParcel2623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._writeToParcel2623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2624;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWindow._describeContents2624);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._describeContents2624);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased2625;
		protected override void onAllReferencesReleased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._onAllReferencesReleased2625);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._onAllReferencesReleased2625);
		}
		internal static global::MonoJavaBridge.MethodId _putString2626;
		public virtual bool putString(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._putString2626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putString2626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2627;
		public virtual byte[] getBlob(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWindow._getBlob2627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getBlob2627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer2628;
		public virtual void copyStringToBuffer(int arg0, int arg1, android.database.CharArrayBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._copyStringToBuffer2628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._copyStringToBuffer2628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isNull2629;
		public virtual bool isNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._isNull2629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isNull2629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getStartPosition2630;
		public virtual int getStartPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWindow._getStartPosition2630);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getStartPosition2630);
		}
		internal static global::MonoJavaBridge.MethodId _setStartPosition2631;
		public virtual void setStartPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._setStartPosition2631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._setStartPosition2631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumRows2632;
		public virtual int getNumRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWindow._getNumRows2632);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getNumRows2632);
		}
		internal static global::MonoJavaBridge.MethodId _setNumColumns2633;
		public virtual bool setNumColumns(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._setNumColumns2633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._setNumColumns2633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _allocRow2634;
		public virtual bool allocRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._allocRow2634);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._allocRow2634);
		}
		internal static global::MonoJavaBridge.MethodId _freeLastRow2635;
		public virtual void freeLastRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWindow._freeLastRow2635);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._freeLastRow2635);
		}
		internal static global::MonoJavaBridge.MethodId _putBlob2636;
		public virtual bool putBlob(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._putBlob2636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putBlob2636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isBlob2637;
		public virtual bool isBlob(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._isBlob2637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isBlob2637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLong2638;
		public virtual bool isLong(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._isLong2638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isLong2638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFloat2639;
		public virtual bool isFloat(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._isFloat2639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isFloat2639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isString2640;
		public virtual bool isString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWindow._isString2640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isString2640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newFromParcel2641;
		public static global::android.database.CursorWindow newFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._newFromParcel2641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _CursorWindow2642;
		public CursorWindow(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._CursorWindow2642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2643;
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
			global::android.database.CursorWindow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWindow"));
			global::android.database.CursorWindow._finalize2611 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "finalize", "()V");
			global::android.database.CursorWindow._getShort2612 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getShort", "(II)S");
			global::android.database.CursorWindow._getInt2613 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getInt", "(II)I");
			global::android.database.CursorWindow._getLong2614 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getLong", "(II)J");
			global::android.database.CursorWindow._putLong2615 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putLong", "(JII)Z");
			global::android.database.CursorWindow._getFloat2616 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getFloat", "(II)F");
			global::android.database.CursorWindow._getDouble2617 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getDouble", "(II)D");
			global::android.database.CursorWindow._putDouble2618 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putDouble", "(DII)Z");
			global::android.database.CursorWindow._clear2619 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "clear", "()V");
			global::android.database.CursorWindow._close2620 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "close", "()V");
			global::android.database.CursorWindow._getString2621 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getString", "(II)Ljava/lang/String;");
			global::android.database.CursorWindow._putNull2622 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putNull", "(II)Z");
			global::android.database.CursorWindow._writeToParcel2623 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.database.CursorWindow._describeContents2624 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "describeContents", "()I");
			global::android.database.CursorWindow._onAllReferencesReleased2625 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.CursorWindow._putString2626 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putString", "(Ljava/lang/String;II)Z");
			global::android.database.CursorWindow._getBlob2627 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getBlob", "(II)[B");
			global::android.database.CursorWindow._copyStringToBuffer2628 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V");
			global::android.database.CursorWindow._isNull2629 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isNull", "(II)Z");
			global::android.database.CursorWindow._getStartPosition2630 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getStartPosition", "()I");
			global::android.database.CursorWindow._setStartPosition2631 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "setStartPosition", "(I)V");
			global::android.database.CursorWindow._getNumRows2632 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getNumRows", "()I");
			global::android.database.CursorWindow._setNumColumns2633 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "setNumColumns", "(I)Z");
			global::android.database.CursorWindow._allocRow2634 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "allocRow", "()Z");
			global::android.database.CursorWindow._freeLastRow2635 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "freeLastRow", "()V");
			global::android.database.CursorWindow._putBlob2636 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putBlob", "([BII)Z");
			global::android.database.CursorWindow._isBlob2637 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isBlob", "(II)Z");
			global::android.database.CursorWindow._isLong2638 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isLong", "(II)Z");
			global::android.database.CursorWindow._isFloat2639 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isFloat", "(II)Z");
			global::android.database.CursorWindow._isString2640 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isString", "(II)Z");
			global::android.database.CursorWindow._newFromParcel2641 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;");
			global::android.database.CursorWindow._CursorWindow2642 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "<init>", "(Z)V");
		}
	}
}

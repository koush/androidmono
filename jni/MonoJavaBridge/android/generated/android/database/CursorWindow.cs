namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CursorWindow : android.database.sqlite.SQLiteClosable, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static CursorWindow()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.CursorWindow), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.CursorWindow(@__env);
			}
		}
		protected CursorWindow(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort2445;
		public virtual short getShort(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.database.CursorWindow._getShort2445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getShort2445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2446;
		public virtual int getInt(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWindow._getInt2446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getInt2446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong2447;
		public virtual long getLong(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.CursorWindow._getLong2447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getLong2447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putLong2448;
		public virtual bool putLong(long arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._putLong2448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putLong2448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2449;
		public virtual float getFloat(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.database.CursorWindow._getFloat2449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getFloat2449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2450;
		public virtual double getDouble(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.database.CursorWindow._getDouble2450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getDouble2450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putDouble2451;
		public virtual bool putDouble(double arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._putDouble2451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putDouble2451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear2452;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._clear2452);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._clear2452);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2453;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._close2453);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._close2453);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2454;
		public virtual global::java.lang.String getString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWindow._getString2454, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getString2454, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putNull2455;
		public virtual bool putNull(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._putNull2455, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putNull2455, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2456;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._writeToParcel2456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._writeToParcel2456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2457;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWindow._describeContents2457);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._describeContents2457);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2458;
		protected override void onAllReferencesReleased() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._onAllReferencesReleased2458);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._onAllReferencesReleased2458);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putString2459;
		public virtual bool putString(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._putString2459, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putString2459, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2460;
		public virtual byte[] getBlob(int arg0, int arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWindow._getBlob2460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getBlob2460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2461;
		public virtual void copyStringToBuffer(int arg0, int arg1, android.database.CharArrayBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._copyStringToBuffer2461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._copyStringToBuffer2461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2462;
		public virtual bool isNull(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._isNull2462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isNull2462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartPosition2463;
		public virtual int getStartPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWindow._getStartPosition2463);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getStartPosition2463);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStartPosition2464;
		public virtual void setStartPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._setStartPosition2464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._setStartPosition2464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumRows2465;
		public virtual int getNumRows() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWindow._getNumRows2465);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getNumRows2465);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNumColumns2466;
		public virtual bool setNumColumns(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._setNumColumns2466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._setNumColumns2466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _allocRow2467;
		public virtual bool allocRow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._allocRow2467);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._allocRow2467);
		}
		internal static global::net.sf.jni4net.jni.MethodId _freeLastRow2468;
		public virtual void freeLastRow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWindow._freeLastRow2468);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._freeLastRow2468);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBlob2469;
		public virtual bool putBlob(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._putBlob2469, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putBlob2469, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBlob2470;
		public virtual bool isBlob(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._isBlob2470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isBlob2470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLong2471;
		public virtual bool isLong(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._isLong2471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isLong2471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFloat2472;
		public virtual bool isFloat(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._isFloat2472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isFloat2472, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isString2473;
		public virtual bool isString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWindow._isString2473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isString2473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newFromParcel2474;
		public static global::android.database.CursorWindow newFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._newFromParcel2474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CursorWindow2475;
		public CursorWindow(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._CursorWindow2475, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2476;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.CursorWindow.staticClass = @__class;
			global::android.database.CursorWindow._getShort2445 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getShort", "(II)S");
			global::android.database.CursorWindow._getInt2446 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getInt", "(II)I");
			global::android.database.CursorWindow._getLong2447 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getLong", "(II)J");
			global::android.database.CursorWindow._putLong2448 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putLong", "(JII)Z");
			global::android.database.CursorWindow._getFloat2449 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getFloat", "(II)F");
			global::android.database.CursorWindow._getDouble2450 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getDouble", "(II)D");
			global::android.database.CursorWindow._putDouble2451 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putDouble", "(DII)Z");
			global::android.database.CursorWindow._clear2452 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "clear", "()V");
			global::android.database.CursorWindow._close2453 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "close", "()V");
			global::android.database.CursorWindow._getString2454 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getString", "(II)Ljava/lang/String;");
			global::android.database.CursorWindow._putNull2455 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putNull", "(II)Z");
			global::android.database.CursorWindow._writeToParcel2456 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.database.CursorWindow._describeContents2457 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "describeContents", "()I");
			global::android.database.CursorWindow._onAllReferencesReleased2458 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.CursorWindow._putString2459 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putString", "(Ljava/lang/String;II)Z");
			global::android.database.CursorWindow._getBlob2460 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getBlob", "(II)[B");
			global::android.database.CursorWindow._copyStringToBuffer2461 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V");
			global::android.database.CursorWindow._isNull2462 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isNull", "(II)Z");
			global::android.database.CursorWindow._getStartPosition2463 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getStartPosition", "()I");
			global::android.database.CursorWindow._setStartPosition2464 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "setStartPosition", "(I)V");
			global::android.database.CursorWindow._getNumRows2465 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "getNumRows", "()I");
			global::android.database.CursorWindow._setNumColumns2466 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "setNumColumns", "(I)Z");
			global::android.database.CursorWindow._allocRow2467 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "allocRow", "()Z");
			global::android.database.CursorWindow._freeLastRow2468 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "freeLastRow", "()V");
			global::android.database.CursorWindow._putBlob2469 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "putBlob", "([BII)Z");
			global::android.database.CursorWindow._isBlob2470 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isBlob", "(II)Z");
			global::android.database.CursorWindow._isLong2471 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isLong", "(II)Z");
			global::android.database.CursorWindow._isFloat2472 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isFloat", "(II)Z");
			global::android.database.CursorWindow._isString2473 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "isString", "(II)Z");
			global::android.database.CursorWindow._newFromParcel2474 = @__env.GetStaticMethodID(global::android.database.CursorWindow.staticClass, "newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;");
			global::android.database.CursorWindow._CursorWindow2475 = @__env.GetMethodID(global::android.database.CursorWindow.staticClass, "<init>", "(Z)V");
		}
	}
}

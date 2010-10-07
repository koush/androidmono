namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CursorWrapper : java.lang.Object, Cursor
	{
		internal static global::java.lang.Class staticClass;
		static CursorWrapper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.CursorWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.CursorWrapper(@__env);
			}
		}
		protected CursorWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort2477;
		public virtual short getShort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.database.CursorWrapper._getShort2477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getShort2477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2478;
		public virtual int getInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getInt2478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getInt2478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong2479;
		public virtual long getLong(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.CursorWrapper._getLong2479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getLong2479, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2480;
		public virtual float getFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.database.CursorWrapper._getFloat2480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getFloat2480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2481;
		public virtual double getDouble(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.database.CursorWrapper._getDouble2481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getDouble2481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2482;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._close2482);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._close2482);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2483;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getString2483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getString2483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2484;
		public virtual bool isFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isFirst2484);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isFirst2484);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2485;
		public virtual bool isClosed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isClosed2485);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isClosed2485);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2486;
		public virtual int getPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getPosition2486);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getPosition2486);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2487;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getExtras2487));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getExtras2487));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2488;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._registerContentObserver2488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerContentObserver2488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2489;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._unregisterContentObserver2489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterContentObserver2489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount2490;
		public virtual int getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getCount2490);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getCount2490);
		}
		internal static global::net.sf.jni4net.jni.MethodId _move2491;
		public virtual bool move(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._move2491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._move2491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2492;
		public virtual bool moveToPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToPosition2492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPosition2492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2493;
		public virtual bool moveToFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToFirst2493);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToFirst2493);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2494;
		public virtual bool moveToLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToLast2494);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToLast2494);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2495;
		public virtual bool moveToNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToNext2495);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToNext2495);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2496;
		public virtual bool moveToPrevious() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToPrevious2496);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPrevious2496);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLast2497;
		public virtual bool isLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isLast2497);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isLast2497);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2498;
		public virtual bool isBeforeFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isBeforeFirst2498);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isBeforeFirst2498);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2499;
		public virtual bool isAfterLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isAfterLast2499);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isAfterLast2499);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2500;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getColumnIndex2500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndex2500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2501;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getColumnIndexOrThrow2501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndexOrThrow2501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2502;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getColumnName2502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnName2502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2503;
		public virtual global::java.lang.String[] getColumnNames() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getColumnNames2503));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnNames2503));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2504;
		public virtual int getColumnCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getColumnCount2504);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnCount2504);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2505;
		public virtual byte[] getBlob(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getBlob2505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getBlob2505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2506;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._copyStringToBuffer2506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._copyStringToBuffer2506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2507;
		public virtual bool isNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isNull2507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isNull2507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2508;
		public virtual void deactivate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._deactivate2508);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._deactivate2508);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requery2509;
		public virtual bool requery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._requery2509);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._requery2509);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2510;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._registerDataSetObserver2510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerDataSetObserver2510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2511;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._unregisterDataSetObserver2511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterDataSetObserver2511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2512;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._setNotificationUri2512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._setNotificationUri2512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2513;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._getWantsAllOnMoveCalls2513);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getWantsAllOnMoveCalls2513);
		}
		internal static global::net.sf.jni4net.jni.MethodId _respond2514;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._respond2514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._respond2514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CursorWrapper2515;
		public CursorWrapper(android.database.Cursor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._CursorWrapper2515, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.CursorWrapper.staticClass = @__class;
			global::android.database.CursorWrapper._getShort2477 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getShort", "(I)S");
			global::android.database.CursorWrapper._getInt2478 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getInt", "(I)I");
			global::android.database.CursorWrapper._getLong2479 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getLong", "(I)J");
			global::android.database.CursorWrapper._getFloat2480 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F");
			global::android.database.CursorWrapper._getDouble2481 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D");
			global::android.database.CursorWrapper._close2482 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "close", "()V");
			global::android.database.CursorWrapper._getString2483 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.CursorWrapper._isFirst2484 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isFirst", "()Z");
			global::android.database.CursorWrapper._isClosed2485 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isClosed", "()Z");
			global::android.database.CursorWrapper._getPosition2486 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getPosition", "()I");
			global::android.database.CursorWrapper._getExtras2487 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.CursorWrapper._registerContentObserver2488 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CursorWrapper._unregisterContentObserver2489 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CursorWrapper._getCount2490 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getCount", "()I");
			global::android.database.CursorWrapper._move2491 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "move", "(I)Z");
			global::android.database.CursorWrapper._moveToPosition2492 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z");
			global::android.database.CursorWrapper._moveToFirst2493 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z");
			global::android.database.CursorWrapper._moveToLast2494 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z");
			global::android.database.CursorWrapper._moveToNext2495 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z");
			global::android.database.CursorWrapper._moveToPrevious2496 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z");
			global::android.database.CursorWrapper._isLast2497 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isLast", "()Z");
			global::android.database.CursorWrapper._isBeforeFirst2498 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z");
			global::android.database.CursorWrapper._isAfterLast2499 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z");
			global::android.database.CursorWrapper._getColumnIndex2500 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.CursorWrapper._getColumnIndexOrThrow2501 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.CursorWrapper._getColumnName2502 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.CursorWrapper._getColumnNames2503 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.CursorWrapper._getColumnCount2504 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I");
			global::android.database.CursorWrapper._getBlob2505 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B");
			global::android.database.CursorWrapper._copyStringToBuffer2506 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.CursorWrapper._isNull2507 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z");
			global::android.database.CursorWrapper._deactivate2508 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "deactivate", "()V");
			global::android.database.CursorWrapper._requery2509 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "requery", "()Z");
			global::android.database.CursorWrapper._registerDataSetObserver2510 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CursorWrapper._unregisterDataSetObserver2511 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CursorWrapper._setNotificationUri2512 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.CursorWrapper._getWantsAllOnMoveCalls2513 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.CursorWrapper._respond2514 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.database.CursorWrapper._CursorWrapper2515 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V");
		}
	}
}

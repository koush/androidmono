namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.CallableStatement_))]
	public partial interface CallableStatement : PreparedStatement
	{
		global::java.lang.Object getObject(int arg0, java.util.Map arg1);
		global::java.lang.Object getObject(java.lang.String arg0);
		global::java.lang.Object getObject(int arg0);
		global::java.lang.Object getObject(java.lang.String arg0, java.util.Map arg1);
		bool getBoolean(int arg0);
		bool getBoolean(java.lang.String arg0);
		byte getByte(int arg0);
		byte getByte(java.lang.String arg0);
		short getShort(int arg0);
		short getShort(java.lang.String arg0);
		int getInt(java.lang.String arg0);
		int getInt(int arg0);
		long getLong(int arg0);
		long getLong(java.lang.String arg0);
		float getFloat(java.lang.String arg0);
		float getFloat(int arg0);
		double getDouble(java.lang.String arg0);
		double getDouble(int arg0);
		byte[] getBytes(int arg0);
		byte[] getBytes(java.lang.String arg0);
		global::java.sql.Array getArray(int arg0);
		global::java.sql.Array getArray(java.lang.String arg0);
		global::java.net.URL getURL(int arg0);
		global::java.net.URL getURL(java.lang.String arg0);
		void setBoolean(java.lang.String arg0, bool arg1);
		void setByte(java.lang.String arg0, byte arg1);
		void setShort(java.lang.String arg0, short arg1);
		void setInt(java.lang.String arg0, int arg1);
		void setLong(java.lang.String arg0, long arg1);
		void setFloat(java.lang.String arg0, float arg1);
		void setDouble(java.lang.String arg0, double arg1);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		global::java.sql.Ref getRef(int arg0);
		global::java.sql.Ref getRef(java.lang.String arg0);
		global::java.lang.String getString(int arg0);
		global::java.lang.String getString(java.lang.String arg0);
		void setURL(java.lang.String arg0, java.net.URL arg1);
		void setTime(java.lang.String arg0, java.sql.Time arg1);
		void setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2);
		global::java.sql.Time getTime(int arg0);
		global::java.sql.Time getTime(java.lang.String arg0);
		global::java.sql.Time getTime(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(int arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(int arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(java.lang.String arg0);
		global::java.sql.Date getDate(int arg0);
		global::java.sql.Timestamp getTimestamp(int arg0);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0);
		global::java.sql.Timestamp getTimestamp(int arg0, java.util.Calendar arg1);
		void setDate(java.lang.String arg0, java.sql.Date arg1);
		void setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2);
		global::java.sql.Blob getBlob(int arg0);
		global::java.sql.Blob getBlob(java.lang.String arg0);
		void setString(java.lang.String arg0, java.lang.String arg1);
		void setObject(java.lang.String arg0, java.lang.Object arg1);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3);
		bool wasNull();
		global::java.math.BigDecimal getBigDecimal(int arg0, int arg1);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0);
		global::java.math.BigDecimal getBigDecimal(int arg0);
		global::java.io.Reader getCharacterStream(int arg0);
		global::java.io.Reader getCharacterStream(java.lang.String arg0);
		global::java.sql.Clob getClob(int arg0);
		global::java.sql.Clob getClob(java.lang.String arg0);
		global::java.lang.String getNString(int arg0);
		global::java.lang.String getNString(java.lang.String arg0);
		global::java.io.Reader getNCharacterStream(java.lang.String arg0);
		global::java.io.Reader getNCharacterStream(int arg0);
		void setBytes(java.lang.String arg0, byte[] arg1);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void registerOutParameter(int arg0, int arg1, java.lang.String arg2);
		void registerOutParameter(int arg0, int arg1, int arg2);
		void registerOutParameter(int arg0, int arg1);
		void registerOutParameter(java.lang.String arg0, int arg1);
		void registerOutParameter(java.lang.String arg0, int arg1, int arg2);
		void registerOutParameter(java.lang.String arg0, int arg1, java.lang.String arg2);
		void setNull(java.lang.String arg0, int arg1, java.lang.String arg2);
		void setNull(java.lang.String arg0, int arg1);
		void setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void setNString(java.lang.String arg0, java.lang.String arg1);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNClob(java.lang.String arg0, java.io.Reader arg1);
		void setClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setClob(java.lang.String arg0, java.io.Reader arg1);
		void setClob(java.lang.String arg0, java.sql.Clob arg1);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void setBlob(java.lang.String arg0, java.sql.Blob arg1);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.CallableStatement))]
	internal sealed partial class CallableStatement_ : java.lang.Object, CallableStatement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CallableStatement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject24113;
		global::java.lang.Object java.sql.CallableStatement.getObject(int arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject24113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject24113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24114;
		global::java.lang.Object java.sql.CallableStatement.getObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject24114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject24114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24115;
		global::java.lang.Object java.sql.CallableStatement.getObject(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject24115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject24115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24116;
		global::java.lang.Object java.sql.CallableStatement.getObject(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject24116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject24116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean24117;
		bool java.sql.CallableStatement.getBoolean(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBoolean24117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBoolean24117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean24118;
		bool java.sql.CallableStatement.getBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBoolean24118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBoolean24118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte24119;
		byte java.sql.CallableStatement.getByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.CallableStatement_._getByte24119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getByte24119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte24120;
		byte java.sql.CallableStatement.getByte(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.CallableStatement_._getByte24120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getByte24120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort24121;
		short java.sql.CallableStatement.getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.CallableStatement_._getShort24121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getShort24121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort24122;
		short java.sql.CallableStatement.getShort(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.CallableStatement_._getShort24122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getShort24122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt24123;
		int java.sql.CallableStatement.getInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getInt24123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getInt24123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt24124;
		int java.sql.CallableStatement.getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getInt24124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getInt24124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong24125;
		long java.sql.CallableStatement.getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.CallableStatement_._getLong24125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getLong24125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong24126;
		long java.sql.CallableStatement.getLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.CallableStatement_._getLong24126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getLong24126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat24127;
		float java.sql.CallableStatement.getFloat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFloat24127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFloat24127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat24128;
		float java.sql.CallableStatement.getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFloat24128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFloat24128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble24129;
		double java.sql.CallableStatement.getDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDouble24129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDouble24129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble24130;
		double java.sql.CallableStatement.getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDouble24130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDouble24130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24131;
		byte[] java.sql.CallableStatement.getBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBytes24131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBytes24131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24132;
		byte[] java.sql.CallableStatement.getBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBytes24132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBytes24132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray24133;
		global::java.sql.Array java.sql.CallableStatement.getArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getArray24133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getArray24133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray24134;
		global::java.sql.Array java.sql.CallableStatement.getArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getArray24134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getArray24134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getURL24135;
		global::java.net.URL java.sql.CallableStatement.getURL(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getURL24135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getURL24135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL24136;
		global::java.net.URL java.sql.CallableStatement.getURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getURL24136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getURL24136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean24137;
		void java.sql.CallableStatement.setBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBoolean24137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBoolean24137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte24138;
		void java.sql.CallableStatement.setByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setByte24138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setByte24138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort24139;
		void java.sql.CallableStatement.setShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setShort24139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setShort24139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt24140;
		void java.sql.CallableStatement.setInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setInt24140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setInt24140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong24141;
		void java.sql.CallableStatement.setLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setLong24141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setLong24141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat24142;
		void java.sql.CallableStatement.setFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFloat24142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFloat24142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble24143;
		void java.sql.CallableStatement.setDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDouble24143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDouble24143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24144;
		void java.sql.CallableStatement.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24145;
		void java.sql.CallableStatement.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRef24146;
		global::java.sql.Ref java.sql.CallableStatement.getRef(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getRef24146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getRef24146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef24147;
		global::java.sql.Ref java.sql.CallableStatement.getRef(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getRef24147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getRef24147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString24148;
		global::java.lang.String java.sql.CallableStatement.getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getString24148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getString24148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString24149;
		global::java.lang.String java.sql.CallableStatement.getString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getString24149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getString24149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setURL24150;
		void java.sql.CallableStatement.setURL(java.lang.String arg0, java.net.URL arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setURL24150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setURL24150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24151;
		void java.sql.CallableStatement.setTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24152;
		void java.sql.CallableStatement.setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTime24153;
		global::java.sql.Time java.sql.CallableStatement.getTime(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24154;
		global::java.sql.Time java.sql.CallableStatement.getTime(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24155;
		global::java.sql.Time java.sql.CallableStatement.getTime(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24156;
		global::java.sql.Time java.sql.CallableStatement.getTime(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24157;
		global::java.sql.Date java.sql.CallableStatement.getDate(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24158;
		global::java.sql.Date java.sql.CallableStatement.getDate(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24159;
		global::java.sql.Date java.sql.CallableStatement.getDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24160;
		global::java.sql.Date java.sql.CallableStatement.getDate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24161;
		global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24162;
		global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24163;
		global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24164;
		global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _setDate24165;
		void java.sql.CallableStatement.setDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24166;
		void java.sql.CallableStatement.setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getBlob24167;
		global::java.sql.Blob java.sql.CallableStatement.getBlob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBlob24167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBlob24167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob24168;
		global::java.sql.Blob java.sql.CallableStatement.getBlob(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBlob24168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBlob24168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _setString24169;
		void java.sql.CallableStatement.setString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setString24169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setString24169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24170;
		void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24171;
		void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24172;
		void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull24173;
		bool java.sql.CallableStatement.wasNull()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._wasNull24173);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._wasNull24173);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24174;
		global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal24174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal24174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24175;
		global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal24175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal24175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24176;
		global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal24176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal24176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24177;
		global::java.io.Reader java.sql.CallableStatement.getCharacterStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getCharacterStream24177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getCharacterStream24177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24178;
		global::java.io.Reader java.sql.CallableStatement.getCharacterStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getCharacterStream24178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getCharacterStream24178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getClob24179;
		global::java.sql.Clob java.sql.CallableStatement.getClob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getClob24179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getClob24179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob24180;
		global::java.sql.Clob java.sql.CallableStatement.getClob(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getClob24180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getClob24180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getNString24181;
		global::java.lang.String java.sql.CallableStatement.getNString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNString24181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNString24181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString24182;
		global::java.lang.String java.sql.CallableStatement.getNString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNString24182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNString24182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24183;
		global::java.io.Reader java.sql.CallableStatement.getNCharacterStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNCharacterStream24183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNCharacterStream24183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24184;
		global::java.io.Reader java.sql.CallableStatement.getNCharacterStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNCharacterStream24184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNCharacterStream24184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24185;
		void java.sql.CallableStatement.setBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBytes24185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBytes24185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24186;
		void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24187;
		void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24188;
		void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24189;
		void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24190;
		void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24191;
		void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24192;
		void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24193;
		void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24194;
		void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24195;
		void java.sql.CallableStatement.setNull(java.lang.String arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24196;
		void java.sql.CallableStatement.setNull(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal24197;
		void java.sql.CallableStatement.setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBigDecimal24197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBigDecimal24197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24198;
		void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24199;
		void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24200;
		void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24201;
		void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24202;
		void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24203;
		void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNString24204;
		void java.sql.CallableStatement.setNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNString24204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNString24204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24205;
		void java.sql.CallableStatement.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24206;
		void java.sql.CallableStatement.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24207;
		void java.sql.CallableStatement.setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24208;
		void java.sql.CallableStatement.setNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24209;
		void java.sql.CallableStatement.setClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24210;
		void java.sql.CallableStatement.setClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24211;
		void java.sql.CallableStatement.setClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24212;
		void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24213;
		void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24214;
		void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean24215;
		void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBoolean24215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBoolean24215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte24216;
		void java.sql.PreparedStatement.setByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setByte24216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setByte24216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort24217;
		void java.sql.PreparedStatement.setShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setShort24217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setShort24217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt24218;
		void java.sql.PreparedStatement.setInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setInt24218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setInt24218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong24219;
		void java.sql.PreparedStatement.setLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setLong24219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setLong24219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat24220;
		void java.sql.PreparedStatement.setFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFloat24220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFloat24220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble24221;
		void java.sql.PreparedStatement.setDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDouble24221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDouble24221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24222;
		void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24223;
		void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setURL24224;
		void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setURL24224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setURL24224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24225;
		void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24226;
		void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24227;
		void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24228;
		void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24229;
		bool java.sql.PreparedStatement.execute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24229);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24229);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24230;
		void java.sql.PreparedStatement.addBatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._addBatch24230);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._addBatch24230);
		}
		internal static global::MonoJavaBridge.MethodId _setString24231;
		void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setString24231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setString24231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24232;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24233;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24234;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData24235;
		global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMetaData24235)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMetaData24235)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24236;
		void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBytes24236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBytes24236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24237;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24238;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24239;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24240;
		void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24241;
		void java.sql.PreparedStatement.setNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal24242;
		void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBigDecimal24242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBigDecimal24242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24243;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24244;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24245;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24246;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24247;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24248;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString24249;
		void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNString24249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNString24249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24250;
		void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24251;
		void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24252;
		void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24253;
		void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24254;
		void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24255;
		void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24256;
		void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24257;
		void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24258;
		void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24259;
		void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24260;
		global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeQuery24260)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeQuery24260)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24261;
		int java.sql.PreparedStatement.executeUpdate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24261);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24261);
		}
		internal static global::MonoJavaBridge.MethodId _setUnicodeStream24262;
		void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setUnicodeStream24262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setUnicodeStream24262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters24263;
		void java.sql.PreparedStatement.clearParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearParameters24263);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearParameters24263);
		}
		internal static global::MonoJavaBridge.MethodId _setRef24264;
		void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setRef24264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setRef24264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray24265;
		void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setArray24265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setArray24265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMetaData24266;
		global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getParameterMetaData24266)) as java.sql.ParameterMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getParameterMetaData24266)) as java.sql.ParameterMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _close24267;
		void java.sql.Statement.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._close24267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._close24267);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24268;
		bool java.sql.Statement.isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._isClosed24268);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._isClosed24268);
		}
		internal static global::MonoJavaBridge.MethodId _execute24269;
		bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24270;
		bool java.sql.Statement.execute(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24271;
		bool java.sql.Statement.execute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute24272;
		bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel24273;
		void java.sql.Statement.cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._cancel24273);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._cancel24273);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24274;
		void java.sql.Statement.addBatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._addBatch24274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._addBatch24274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24275;
		global::java.sql.Connection java.sql.Statement.getConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getConnection24275)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getConnection24275)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24276;
		global::java.sql.ResultSet java.sql.Statement.getResultSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSet24276)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSet24276)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24277;
		global::java.sql.SQLWarning java.sql.Statement.getWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getWarnings24277)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getWarnings24277)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24278;
		void java.sql.Statement.clearWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearWarnings24278);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearWarnings24278);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection24279;
		void java.sql.Statement.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFetchDirection24279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFetchDirection24279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection24280;
		int java.sql.Statement.getFetchDirection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFetchDirection24280);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFetchDirection24280);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize24281;
		void java.sql.Statement.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFetchSize24281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFetchSize24281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize24282;
		int java.sql.Statement.getFetchSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFetchSize24282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFetchSize24282);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24283;
		global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeQuery24283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeQuery24283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24284;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24285;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24286;
		int java.sql.Statement.executeUpdate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24287;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize24288;
		int java.sql.Statement.getMaxFieldSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMaxFieldSize24288);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMaxFieldSize24288);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize24289;
		void java.sql.Statement.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setMaxFieldSize24289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setMaxFieldSize24289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows24290;
		int java.sql.Statement.getMaxRows()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMaxRows24290);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMaxRows24290);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows24291;
		void java.sql.Statement.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setMaxRows24291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setMaxRows24291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing24292;
		void java.sql.Statement.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setEscapeProcessing24292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setEscapeProcessing24292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout24293;
		int java.sql.Statement.getQueryTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getQueryTimeout24293);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getQueryTimeout24293);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout24294;
		void java.sql.Statement.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setQueryTimeout24294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setQueryTimeout24294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName24295;
		void java.sql.Statement.setCursorName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCursorName24295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCursorName24295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount24296;
		int java.sql.Statement.getUpdateCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getUpdateCount24296);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getUpdateCount24296);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24297;
		bool java.sql.Statement.getMoreResults()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMoreResults24297);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMoreResults24297);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24298;
		bool java.sql.Statement.getMoreResults(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMoreResults24298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMoreResults24298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency24299;
		int java.sql.Statement.getResultSetConcurrency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetConcurrency24299);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetConcurrency24299);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType24300;
		int java.sql.Statement.getResultSetType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetType24300);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetType24300);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch24301;
		void java.sql.Statement.clearBatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearBatch24301);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearBatch24301);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch24302;
		int[] java.sql.Statement.executeBatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeBatch24302)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeBatch24302)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys24303;
		global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getGeneratedKeys24303)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getGeneratedKeys24303)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24304;
		int java.sql.Statement.getResultSetHoldability()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetHoldability24304);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetHoldability24304);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable24305;
		void java.sql.Statement.setPoolable(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setPoolable24305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setPoolable24305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable24306;
		bool java.sql.Statement.isPoolable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._isPoolable24306);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._isPoolable24306);
		}
		static CallableStatement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.CallableStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/CallableStatement"));
			global::java.sql.CallableStatement_._getObject24113 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject24114 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject24115 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject24116 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getBoolean24117 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBoolean", "(I)Z");
			global::java.sql.CallableStatement_._getBoolean24118 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._getByte24119 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getByte", "(I)B");
			global::java.sql.CallableStatement_._getByte24120 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::java.sql.CallableStatement_._getShort24121 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getShort", "(I)S");
			global::java.sql.CallableStatement_._getShort24122 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::java.sql.CallableStatement_._getInt24123 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._getInt24124 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getInt", "(I)I");
			global::java.sql.CallableStatement_._getLong24125 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getLong", "(I)J");
			global::java.sql.CallableStatement_._getLong24126 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::java.sql.CallableStatement_._getFloat24127 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::java.sql.CallableStatement_._getFloat24128 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFloat", "(I)F");
			global::java.sql.CallableStatement_._getDouble24129 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::java.sql.CallableStatement_._getDouble24130 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDouble", "(I)D");
			global::java.sql.CallableStatement_._getBytes24131 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBytes", "(I)[B");
			global::java.sql.CallableStatement_._getBytes24132 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.sql.CallableStatement_._getArray24133 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::java.sql.CallableStatement_._getArray24134 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::java.sql.CallableStatement_._getURL24135 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::java.sql.CallableStatement_._getURL24136 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.sql.CallableStatement_._setBoolean24137 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBoolean", "(Ljava/lang/String;Z)V");
			global::java.sql.CallableStatement_._setByte24138 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setByte", "(Ljava/lang/String;B)V");
			global::java.sql.CallableStatement_._setShort24139 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setShort", "(Ljava/lang/String;S)V");
			global::java.sql.CallableStatement_._setInt24140 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setInt", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._setLong24141 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setLong", "(Ljava/lang/String;J)V");
			global::java.sql.CallableStatement_._setFloat24142 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFloat", "(Ljava/lang/String;F)V");
			global::java.sql.CallableStatement_._setDouble24143 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDouble", "(Ljava/lang/String;D)V");
			global::java.sql.CallableStatement_._setTimestamp24144 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setTimestamp24145 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::java.sql.CallableStatement_._getRef24146 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::java.sql.CallableStatement_._getRef24147 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::java.sql.CallableStatement_._getString24148 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getString24149 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.CallableStatement_._setURL24150 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setURL", "(Ljava/lang/String;Ljava/net/URL;)V");
			global::java.sql.CallableStatement_._setTime24151 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::java.sql.CallableStatement_._setTime24152 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._getTime24153 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime24154 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime24155 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime24156 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getDate24157 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate24158 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate24159 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate24160 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getTimestamp24161 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp24162 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp24163 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp24164 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._setDate24165 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::java.sql.CallableStatement_._setDate24166 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._getBlob24167 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::java.sql.CallableStatement_._getBlob24168 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::java.sql.CallableStatement_._setString24169 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._setObject24170 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.sql.CallableStatement_._setObject24171 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::java.sql.CallableStatement_._setObject24172 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V");
			global::java.sql.CallableStatement_._wasNull24173 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "wasNull", "()Z");
			global::java.sql.CallableStatement_._getBigDecimal24174 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getBigDecimal24175 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getBigDecimal24176 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getCharacterStream24177 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getCharacterStream24178 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getClob24179 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::java.sql.CallableStatement_._getClob24180 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::java.sql.CallableStatement_._getNString24181 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getNString24182 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getNCharacterStream24183 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getNCharacterStream24184 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._setBytes24185 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBytes", "(Ljava/lang/String;[B)V");
			global::java.sql.CallableStatement_._setBinaryStream24186 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setBinaryStream24187 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBinaryStream24188 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._registerOutParameter24189 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(IILjava/lang/String;)V");
			global::java.sql.CallableStatement_._registerOutParameter24190 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(III)V");
			global::java.sql.CallableStatement_._registerOutParameter24191 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(II)V");
			global::java.sql.CallableStatement_._registerOutParameter24192 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._registerOutParameter24193 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;II)V");
			global::java.sql.CallableStatement_._registerOutParameter24194 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull24195 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull24196 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._setBigDecimal24197 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::java.sql.CallableStatement_._setAsciiStream24198 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setAsciiStream24199 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setAsciiStream24200 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setCharacterStream24201 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setCharacterStream24202 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setCharacterStream24203 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::java.sql.CallableStatement_._setNString24204 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._setNCharacterStream24205 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNCharacterStream24206 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNClob24207 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNClob24208 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setClob24209 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob24210 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setClob24211 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::java.sql.CallableStatement_._setBlob24212 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBlob24213 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::java.sql.CallableStatement_._setBlob24214 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setBoolean24215 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBoolean", "(IZ)V");
			global::java.sql.CallableStatement_._setByte24216 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setByte", "(IB)V");
			global::java.sql.CallableStatement_._setShort24217 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setShort", "(IS)V");
			global::java.sql.CallableStatement_._setInt24218 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setInt", "(II)V");
			global::java.sql.CallableStatement_._setLong24219 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setLong", "(IJ)V");
			global::java.sql.CallableStatement_._setFloat24220 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFloat", "(IF)V");
			global::java.sql.CallableStatement_._setDouble24221 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDouble", "(ID)V");
			global::java.sql.CallableStatement_._setTimestamp24222 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.CallableStatement_._setTimestamp24223 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setURL24224 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::java.sql.CallableStatement_._setTime24225 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setTime24226 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::java.sql.CallableStatement_._setDate24227 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setDate24228 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::java.sql.CallableStatement_._execute24229 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "()Z");
			global::java.sql.CallableStatement_._addBatch24230 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "addBatch", "()V");
			global::java.sql.CallableStatement_._setString24231 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setObject24232 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::java.sql.CallableStatement_._setObject24233 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::java.sql.CallableStatement_._setObject24234 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::java.sql.CallableStatement_._getMetaData24235 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.CallableStatement_._setBytes24236 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBytes", "(I[B)V");
			global::java.sql.CallableStatement_._setBinaryStream24237 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setBinaryStream24238 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setBinaryStream24239 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setNull24240 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull24241 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(II)V");
			global::java.sql.CallableStatement_._setBigDecimal24242 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.CallableStatement_._setAsciiStream24243 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setAsciiStream24244 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setAsciiStream24245 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setCharacterStream24246 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.CallableStatement_._setCharacterStream24247 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setCharacterStream24248 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNString24249 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNCharacterStream24250 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNCharacterStream24251 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNClob24252 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNClob24253 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob24254 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::java.sql.CallableStatement_._setClob24255 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob24256 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setBlob24257 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.CallableStatement_._setBlob24258 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBlob24259 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._executeQuery24260 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._executeUpdate24261 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "()I");
			global::java.sql.CallableStatement_._setUnicodeStream24262 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._clearParameters24263 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearParameters", "()V");
			global::java.sql.CallableStatement_._setRef24264 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::java.sql.CallableStatement_._setArray24265 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::java.sql.CallableStatement_._getParameterMetaData24266 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;");
			global::java.sql.CallableStatement_._close24267 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "close", "()V");
			global::java.sql.CallableStatement_._isClosed24268 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "isClosed", "()Z");
			global::java.sql.CallableStatement_._execute24269 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.CallableStatement_._execute24270 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.CallableStatement_._execute24271 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._execute24272 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._cancel24273 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "cancel", "()V");
			global::java.sql.CallableStatement_._addBatch24274 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._getConnection24275 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.CallableStatement_._getResultSet24276 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._getWarnings24277 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.CallableStatement_._clearWarnings24278 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearWarnings", "()V");
			global::java.sql.CallableStatement_._setFetchDirection24279 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.CallableStatement_._getFetchDirection24280 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.CallableStatement_._setFetchSize24281 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.CallableStatement_._getFetchSize24282 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFetchSize", "()I");
			global::java.sql.CallableStatement_._executeQuery24283 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._executeUpdate24284 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.CallableStatement_._executeUpdate24285 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.CallableStatement_._executeUpdate24286 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._executeUpdate24287 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._getMaxFieldSize24288 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.CallableStatement_._setMaxFieldSize24289 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.CallableStatement_._getMaxRows24290 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMaxRows", "()I");
			global::java.sql.CallableStatement_._setMaxRows24291 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.CallableStatement_._setEscapeProcessing24292 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.CallableStatement_._getQueryTimeout24293 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.CallableStatement_._setQueryTimeout24294 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.CallableStatement_._setCursorName24295 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._getUpdateCount24296 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.CallableStatement_._getMoreResults24297 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.CallableStatement_._getMoreResults24298 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.CallableStatement_._getResultSetConcurrency24299 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.CallableStatement_._getResultSetType24300 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetType", "()I");
			global::java.sql.CallableStatement_._clearBatch24301 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearBatch", "()V");
			global::java.sql.CallableStatement_._executeBatch24302 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeBatch", "()[I");
			global::java.sql.CallableStatement_._getGeneratedKeys24303 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._getResultSetHoldability24304 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.CallableStatement_._setPoolable24305 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.CallableStatement_._isPoolable24306 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "isPoolable", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
